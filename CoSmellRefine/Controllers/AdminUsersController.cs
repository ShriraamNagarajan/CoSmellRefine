using Azure.Core;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoSmellRefine.Controllers
{
    [Authorize]
    public class AdminUsersController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AdminUsersController(IUserRepository userRepository,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userRepository = userRepository;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }



        [HttpGet]
        [ActionName("List")]
        public async Task<IActionResult> List(
              string? searchQuery,
              string? sortBy,
              string? sortDirection,
              int pageSize = 3,
              int pageNumber = 1)
        {
            var totalRecords = await userRepository.CountAsync();
            var totalPages = Math.Ceiling((decimal)totalRecords / pageSize);

            if (pageNumber > totalPages)
            {
                pageNumber--;
            }

            if (pageNumber < 1)
            {
                pageNumber++;
            }


            ViewBag.TotalPages = totalPages;
            ViewBag.SearchQuery = searchQuery;
            ViewBag.SortBy = sortBy;
            ViewBag.SortDirection = sortDirection;
            ViewBag.PageSize = pageSize;
            ViewBag.PageNumber = pageNumber;

            var users = await userRepository.GetAllAsync(searchQuery, sortBy, sortDirection, pageNumber, pageSize);


            var userViewModels = new List<UserViewModel>();

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                var roleList = new List<IdentityRole>();

                foreach (var roleName in roles)
                {
                    var role = await roleManager.FindByNameAsync(roleName);
                    if (role != null)
                    {
                        roleList.Add(role);
                    }
                }

                var userViewModel = new UserViewModel
                {
                    Id = new Guid(user.Id),
                    Username = user.UserName,
                    Email = user.Email,
                    Roles = roleList
                };

                userViewModels.Add(userViewModel);
            }

            return View(userViewModels);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AdminUsersViewModel addUserRequest)
        {
            //add custom validation
            ValidatePassword(addUserRequest);
            ValidateRoles(addUserRequest);

            if (ModelState.IsValid)
            {

                var identityUser = new IdentityUser
                {
                    UserName = addUserRequest.Username,
                    Email = addUserRequest.Email
                };


                var identityResult =
                    await userManager.CreateAsync(identityUser, addUserRequest.Password);

                if (identityResult is not null)
                {
                    if (identityResult.Succeeded)
                    {
                        // assign roles to this user
                        var roles = new List<string>();

                        if (addUserRequest.DeveloperRoleCheckbox)
                        {
                            roles.Add("Developer");
                        }
                        if (addUserRequest.ModeratorRoleCheckbox)
                        {
                            roles.Add("Moderator");
                        }

                        identityResult =
                            await userManager.AddToRolesAsync(identityUser, roles);

                        if (identityResult is not null && identityResult.Succeeded)
                        {
                            TempData["success"] = "User has been added successfully";
                            return RedirectToAction("List", "AdminUsers");
                        }

                    }
                }

            }

            TempData["error"] = "Failed to add user";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userRepository.GetAsync(id);
            var roles = await userManager.GetRolesAsync(user);
            var developerCheckbox = roles.Contains("Developer") ? true : false;
            var moderatorCheckbox = roles.Contains("Moderator") ? true: false;
            if (user == null)
            {
                TempData["error"] = "User doesn't exist";
                return BadRequest();
            }

            var viewModel = new AdminUsersViewModel
            {
                Id = id,
                Username = user.UserName,
                Password = user.PasswordHash,
                Email = user.Email,
                DeveloperRoleCheckbox = developerCheckbox,
                ModeratorRoleCheckbox = moderatorCheckbox
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminUsersViewModel model)
        {
            ValidateRoles(model);
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Failed to update user";
                return RedirectToAction(nameof(Edit), new {id = model.Id});
            }

            var user = await userRepository.GetAsync(model.Id);
            if (user == null)
            {
                TempData["error"] = "User doesn't exist";
                return BadRequest();
            }

            var roles = await userManager.GetRolesAsync(user);
            await UpdateUserRoles(user, roles, model);

            TempData["success"] = "User has been updated successfully";
            return RedirectToAction("List", "AdminUsers");
        }



        private void ValidatePassword(AdminUsersViewModel addUserRequest)
        {
            if (addUserRequest.Password is not null)
            {
                if (addUserRequest.Password.Length < 8)
                {
                    ModelState.AddModelError("Password", "Password must be at least 8 characters long.");
                }
                if (!addUserRequest.Password.Any(char.IsDigit))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one digit.");
                }
                if (!addUserRequest.Password.Any(char.IsLower))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one lowercase letter.");
                }
                if (!addUserRequest.Password.Any(char.IsUpper))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one uppercase letter.");
                }
                if (!addUserRequest.Password.Any(c => !char.IsLetterOrDigit(c)))
                {
                    ModelState.AddModelError("Password", "Password must contain at least one non-alphanumeric character.");
                }
                if (registerViewModel.Password.Distinct().Count() < 2)
                {
                    ModelState.AddModelError("Password", "Password must contain at least two different characters.");
                }
            }
        }

        private void ValidateRoles(AdminUsersViewModel model)
        {
            if(!model.DeveloperRoleCheckbox && !model.ModeratorRoleCheckbox)
            {
                ModelState.AddModelError("ModeratorRoleCheckbox", "You have to select at least one role");
            }
        }

        private async Task UpdateUserRoles(IdentityUser user, IList<string> currentRoles, AdminUsersViewModel model)
        {
            if (model.ModeratorRoleCheckbox && !currentRoles.Contains("Moderator"))
            {
                await userManager.AddToRoleAsync(user, "Moderator");
            }
            else if (!model.ModeratorRoleCheckbox && currentRoles.Contains("Moderator"))
            {
                await userManager.RemoveFromRoleAsync(user, "Moderator");
            }

            if (model.DeveloperRoleCheckbox && !currentRoles.Contains("Developer"))
            {
                await userManager.AddToRoleAsync(user, "Developer");
            }
            else if (!model.DeveloperRoleCheckbox && currentRoles.Contains("Developer"))
            {
                await userManager.RemoveFromRoleAsync(user, "Developer");
            }
        }



        #region API Calls

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());

            if (user is not null)
            {
                var identityResult = await userManager.DeleteAsync(user);

                if (identityResult is not null && identityResult.Succeeded)
                {
                    TempData["success"] = "The user has been deleted successfully";
                    return Json(new { success = true, message = "Deleted Successfully" });

                }
            }

            TempData["error"] = "Failed to delete the user.";
            return Json(new { success = false, message = "Error while deleting" });
        }
        #endregion
    }
}
