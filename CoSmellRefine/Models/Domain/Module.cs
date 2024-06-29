using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class Module
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CodeSmellId {  get; set; }

        [ForeignKey("CodeSmellId")]
        [ValidateNever]
        public CodeSmell CodeSmell { get; set; }

      
        public Guid? CodeSmellCategoryId { get; set; }

        [ForeignKey("CodeSmellCategoryId")]
        [ValidateNever]
        public CodeSmellCategory CodeSmellCategory { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]  
        public string Description { get; set; }

        [Required]
        public string ReadingContent { get; set; }

        [Required]
        public DateTime LastModifiedDate { get; set; }


        //Navigation Property
        public ICollection<ModuleVideo> Videos { get; set; }
        public ICollection<Flashcard> Flashcards { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }

    }
}
