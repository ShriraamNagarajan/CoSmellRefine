using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime SentTime { get; set; }

        [Required]
        public bool IsRead { get; set; }

    }
}
