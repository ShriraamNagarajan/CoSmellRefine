using CoSmellRefine.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoSmellRefine.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {

            //add custom password validation
            ValidatePassword(registerViewModel);

            if (ModelState.IsValid)
            {
                var identityUser = new IdentityUser
                {
                    UserName = registerViewModel.Username,
                    Email = registerViewModel.Email
                };

                var identityResult = await userManager.CreateAsync(identityUser, registerViewModel.Password);

                if (identityResult.Succeeded)
                {
                    // assign this user the "Developer" role
                    var roleIdentityResult = await userManager.AddToRoleAsync(identityUser, "Developer");

                    if (roleIdentityResult.Succeeded)
                    {
                        // Show success notification
                        TempData["success"] = "Successful Registration";
                        return RedirectToAction("Login");
                    }
                }
            }

            // Show error notification
            TempData["error"] = "Unsuccessfuly Registration";
            return View();
        }




        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var signInResult = await signInManager.PasswordSignInAsync(loginViewModel.Username,
                loginViewModel.Password, false, false);

            if (signInResult != null && signInResult.Succeeded)
            {
                // Show success notification
                TempData["success"] = "Successful Login";
                var user = await userManager.GetUserAsync(User);
                var roles = await userManager.GetRolesAsync(user);
                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "AdminDashboard");
                }
                else if (roles.Contains("Moderator"))
                {
                    return RedirectToAction("Index", "ModeratorDashboard");
                }
                else if (roles.Contains("Developer"))
                {
                    // Default to user dashboard or home
                    return RedirectToAction("Index", "DeveloperDashboard");
                }
            }

            // Show errors
            TempData["error"] = "Unsuccessful Login";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private void ValidatePassword(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Password is not null)
            {
                if (registerViewModel.Password.Length < 8)
                {
                    ModelState.AddModelError("Password", "Password must be at least 8 characters long.");
                }
                if (!registerViewModel.Password.Any(char.IsDigit))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one digit.");
                }
                if (!registerViewModel.Password.Any(char.IsLower))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one lowercase letter.");
                }
                if (!registerViewModel.Password.Any(char.IsUpper))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one uppercase letter.");
                }
                if (!registerViewModel.Password.Any(c => !char.IsLetterOrDigit(c)))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one non-alphanumeric character.");
                }
                if (registerViewModel.Password.Distinct().Count() < registerViewModel.Password.Length - 1)
                {
                    ModelState.AddModelError("Password", "Password must contain at least one non-alphanumeric character.");
                }
            }
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { ReturnUrl = returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/DeveloperDashboard/Index");
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
                return View(nameof(Login));
            }

            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var accessToken = info.AuthenticationTokens.FirstOrDefault(t => t.Name == "access_token")?.Value;

            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInResult.Succeeded)
            {
                var user = await userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
                if (user != null)
                {
                    if (accessToken != null)
                    {
                        var existingClaims = await userManager.GetClaimsAsync(user);
                        var accessTokenClaims = existingClaims.Where(c => c.Type == "access_token").ToList();

                        if (accessTokenClaims.Any())
                        {
                            await userManager.RemoveClaimsAsync(user, accessTokenClaims);
                        }

                        var newClaim = new Claim("access_token", accessToken);
                        await userManager.AddClaimAsync(user, newClaim);
                    }
                }

                return LocalRedirect(returnUrl);
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                if (email != null)
                {
                    var user = new IdentityUser { UserName = email, Email = email };
                    var result = await userManager.CreateAsync(user);
                    if (result.Succeeded)
                    {
                        result = await userManager.AddLoginAsync(user, info);
                        if (result.Succeeded)
                        {
                            if (accessToken != null)
                            {
                                var newClaim = new Claim("access_token", accessToken);
                                await userManager.AddClaimAsync(user, newClaim);
                            }
                            await signInManager.SignInAsync(user, isPersistent: false);
                            return LocalRedirect(returnUrl);
                        }
                    }
                }
                return View("ExternalLoginFailure");
            }
        }







    }
}
