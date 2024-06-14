using Azure;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.Domain
{
    public class RefactoringTechnique
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        //Navigation Property
        public ICollection<CodeSmell> CodeSmellList { get; set; }
        public ICollection<Question> QuestionList { get; set; }
        public ICollection<QuestionResponse> ResponseList { get; set; }
    }
}
