using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.Domain
{
    public class Quiz
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string Choices { get; set; }

        [Required]
        public string Answer { get; set; }

        public Guid ModuleId { get; set; }

        [ForeignKey("ModuleId")]
        [ValidateNever]
        public Module Module { get; set; }
    }
}
