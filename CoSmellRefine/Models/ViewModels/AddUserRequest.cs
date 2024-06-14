namespace CoSmellRefine.Models.ViewModels
{
    public class AddUserRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool DeveloperRoleCheckbox { get; set; }

        public bool AdminRoleCheckbox { get; set; }

        public bool ModeratorRoleCheckbox { get; set; }
    }
}
