using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class CodeSmell
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description {  get; set; }

        public Guid CodeSmellCategoryId {  get; set; }

        [ForeignKey("CodeSmellCategoryId")]
        [ValidateNever]
        public CodeSmellCategory CodeSmellCategory { get; set; }


        //Navigation Property
        public ICollection<RefactoringTechnique> RefactoringTechniqueList { get; set; }
        public ICollection<Question> QuestionList { get; set; }

        public ICollection<QuestionResponse> ResponseList { get; set; }
    }
}
