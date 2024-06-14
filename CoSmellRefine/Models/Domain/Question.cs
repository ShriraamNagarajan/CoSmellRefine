using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class Question
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]  
        public DateTime PostedDate { get; set;}

        [Required]  
        public DateTime ModifiedDate { get; set; }

        [Required]  
        public string Status { get; set; }

        [Required]  
        public string CodeSnippet { get; set; }

        //Navigation Property
        public ICollection<QuestionImage> Images { get; set; }
        public ICollection<CodeSmell> CodeSmellList { get; set; }
        public ICollection<RefactoringTechnique> RefactoringTechniques { get; set; }
        public ICollection<QuestionResponse> Responses { get; set; }



    }
}
