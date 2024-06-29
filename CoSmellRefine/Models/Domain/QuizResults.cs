using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.Domain
{
    public class QuizResults
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }


        [Required]
        public Guid ModuleId { get; set; }

        [ForeignKey("ModuleId")]
        [ValidateNever]
        public Module Module { get; set; }

        [Required]
        public DateTime CompletedDate { get; set; }

        [Required]
        public double Result { get; set; }
    }
}
