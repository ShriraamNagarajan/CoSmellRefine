using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoSmellRefine.Models.ViewModels
{
    public class AddResponseViewModel
    {
        public Guid QuestionId { get; set; }
        public string Body { get; set; }
        public string CodeSnippet { get; set; }
        public List<Guid> SelectedCodeSmellIds { get; set; } // For selected code smell IDs

        [ValidateNever]
        public List<SelectListItem> CodeSmells { get; set; } // For all code smells

        public List<Guid> SelectedRefactoringTechniqueIds { get; set; } // For selected refacotring technique IDs

        [ValidateNever]
        public List<SelectListItem> RefactoringTechniques { get; set; } // For all refactoring techniques
    }
}
