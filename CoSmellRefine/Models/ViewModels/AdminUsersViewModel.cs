using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CoSmellRefine.Models.ViewModels
{
    public class AdminUsersViewModel
    {
        [ValidateNever]
        public string Id { get; set; }    
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool DeveloperRoleCheckbox { get; set; }
        public bool ModeratorRoleCheckbox { get; set; }
    }
}
