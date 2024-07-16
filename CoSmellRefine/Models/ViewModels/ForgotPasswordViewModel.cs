using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
