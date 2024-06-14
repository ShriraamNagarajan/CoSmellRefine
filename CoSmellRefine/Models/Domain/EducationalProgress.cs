using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class EducationalProgress
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }

        public Guid CurrentModuleId { get; set; }

        [ForeignKey("CurrentModuleId")]
        [ValidateNever]
        public Module CurrentModule { get; set; }

        [Required]
        public DateTime LastAccessed { get; set; }

    }
}
