using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class QuestionImage
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        [ValidateNever]
        public Question Question { get; set; }

        [Required]
        public string ImageUrl { get; set; }    

    }
}
