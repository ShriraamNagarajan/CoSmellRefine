using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.Domain
{
    public class ModuleVideo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ModuleId { get; set; }

        [ForeignKey("ModuleId")]
        [ValidateNever]
        public Module Module { get; set; }

        [Required]
        public string VideoUrl { get; set; }
    }
}
