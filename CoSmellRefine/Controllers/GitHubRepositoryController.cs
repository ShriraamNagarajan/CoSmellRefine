using CoSmellRefine.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace CoSmellRefine.Controllers
{
    public class GitHubRepositoryController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpClientFactory _clientFactory;
        public GitHubRepositoryController(UserManager<IdentityUser> userManager, IHttpClientFactory clientFactory)
        {
            this._userManager = userManager;    
            this._clientFactory = clientFactory;    
            
        }
        public async Task<IActionResult> Repositories()
        {
            var user = await _userManager.GetUserAsync(User);
            var claims = await _userManager.GetClaimsAsync(user);
            var accessToken = claims.FirstOrDefault(c => c.Type == "access_token")?.Value;
            if (accessToken == null)
            {
                TempData["failure"] = "You have to login through GitHub to use this feature";
                return RedirectToAction(nameof(AccountController.Login), "Account");
            }
            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("CoSmellRefine", "1.0"));

            var response = await client.GetStringAsync("https://api.github.com/user/repos");
            var repositories = JsonSerializer.Deserialize<List<Repository>>(response);

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
