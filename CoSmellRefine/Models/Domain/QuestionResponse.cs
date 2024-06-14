using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class QuestionResponse
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }

        [Required]
        public Guid? QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        [ValidateNever]
        public Question Question { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime PostedDate { get; set; }

        [Required]
        public string Status { get;  set; }

        //NavigationProperty
        public ICollection<Vote> Votes { get; set; }

        public ICollection<RefactoringTechnique> RefactoringTechniques { get; set; }
        public ICollection<CodeSmell> CodeSmellList { get; set; }





    }
}
