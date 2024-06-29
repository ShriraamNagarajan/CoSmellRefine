using CoSmellRefine.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace CoSmellRefine.Models.ViewModels
{
    public class QuestionResponseViewModel
    {
        public Guid Id { get; set; }    
        public IdentityUser User { get; set; }
        public string Body { get; set; }
        public string CodeSnippet { get; set; }
        public DateTime PostedDate { get; set; }
        public int VoteCount { get; set; }

        public Vote VoteByUser { get; set; }  
        
        public bool IsDeleted { get; set; }
        public ICollection<RefactoringTechnique> RefactoringTechniques { get; set; }
        public ICollection<CodeSmell> CodeSmellList { get; set; }

        public IEnumerable<ResponseComment> ResponseComments { get; set; }

    }
}
