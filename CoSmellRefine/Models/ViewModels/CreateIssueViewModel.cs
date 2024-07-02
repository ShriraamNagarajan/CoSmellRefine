using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoSmellRefine.Models.ViewModels
{
    public class CreateIssueViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Repo { get; set; }
        public string Owner { get; set; }
        public List<SelectListItem> Repositories { get; set; }
    }
}
