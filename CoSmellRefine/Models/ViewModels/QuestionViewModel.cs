using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoSmellRefine.Models.ViewModels
{
    public class QuestionViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }
        public string CodeSnippet { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<Guid> SelectedCodeSmellIds { get; set; } // For selected code smell IDs

        [ValidateNever]
        public List<SelectListItem> CodeSmells { get; set; } // For all code smells
    }
}
