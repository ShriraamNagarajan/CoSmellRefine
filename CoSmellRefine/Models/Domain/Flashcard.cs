using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class Flashcard
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        public Guid ModuleId { get; set; }

        [ForeignKey("ModuleId")]
        [ValidateNever]
        public Module Module { get; set; }

    }
}
