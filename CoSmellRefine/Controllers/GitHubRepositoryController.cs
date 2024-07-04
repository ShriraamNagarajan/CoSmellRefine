using CoSmellRefine.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Headers;
using System.Text.Json;

namespace CoSmellRefine.Controllers
{
    public class GitHubRepositoryController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMemoryCache _memoryCache;
        public GitHubRepositoryController(UserManager<IdentityUser> userManager, IHttpClientFactory clientFactory, IMemoryCache memeoryCache)
        {
            this._userManager = userManager;    
            this._clientFactory = clientFactory;   
            this._memoryCache = memeoryCache;
            
        }
        public async Task<IActionResult> Repositories()
        {
            var user = await _userManager.GetUserAsync(User);
            var claims = await _userManager.GetClaimsAsync(user);
            var accessToken = claims.FirstOrDefault(c => c.Type == "access_token")?.Value;
            if (accessToken == null)
            {
                TempData["error"] = "You have to login through GitHub to use this feature";
                return View("LoginPrompt");
            }
            var cacheKey = $"repositories_{user.Id}";
            if (!_memoryCache.TryGetValue(cacheKey, out List<Repository> repositories))
            {
                var client = _clientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("CoSmellRefine", "1.0"));

                var response = await client.GetStringAsync("https://api.github.com/user/repos");
                repositories = JsonSerializer.Deserialize<List<Repository>>(response);

                // Set cache options
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(5)) // Sliding expiration
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(10)) // Absolute expiration
                    .SetPriority(CacheItemPriority.High); // Priority

                // Cache the data
                _memoryCache.Set(cacheKey, repositories, cacheEntryOptions);
            }

            return View(repositories);
        }

        public async Task<IActionResult> RepositoryContent(string owner, string repo, string path = "")
        {
            var user = await _userManager.GetUserAsync(User);
            var claims = await _userManager.GetClaimsAsync(user);
            var accessToken = claims.FirstOrDefault(c => c.Type == "access_token")?.Value;

            if (accessToken == null)
            {
                return RedirectToAction(nameof(AccountController.Login), "Account");
            }

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("CoSmellRefine", "1.0"));

            var url = $"https://api.github.com/repos/{owner}/{repo}/contents/{path}";
            var response = await client.GetStringAsync(url);
            var contents = JsonSerializer.Deserialize<List<RepositoryContent>>(response);

            ViewData["Owner"] = owner;
            ViewData["Repo"] = repo;

            return View(contents);
        }

        public async Task<IActionResult> RepositoryFileContent(string owner, string repo, string path)
        {
            var user = await _userManager.GetUserAsync(User);
            var claims = await _userManager.GetClaimsAsync(user);
            var accessToken = claims.FirstOrDefault(c => c.Type == "access_token")?.Value;

            if (accessToken == null)
            {
                return RedirectToAction(nameof(AccountController.Login), "Account");
            }

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("CoSmellRefine", "1.0"));

            var url = $"https://api.github.com/repos/{owner}/{repo}/contents/{path}";
            var response = await client.GetStringAsync(url);
            var contentData = JsonSerializer.Deserialize<RepositoryContent>(response);

            if (contentData.Type == "file" && contentData.DownloadUrl != null)
            {
                var fileResponse = await client.GetStringAsync(contentData.DownloadUrl);
                ViewData["FileName"] = contentData.Name;
                ViewData["FileContent"] = fileResponse;
                ViewData["Owner"] = owner;
                ViewData["Repo"] = repo;
                return View("FileContent");
            }

            return RedirectToAction(nameof(RepositoryContent), new { owner, repo, path });
        }

    }
}
