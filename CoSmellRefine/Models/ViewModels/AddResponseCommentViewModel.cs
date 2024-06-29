using Microsoft.AspNetCore.Identity;

namespace CoSmellRefine.Models.ViewModels
{
    public class AddResponseCommentViewModel
    {
        public Guid ResponseId { get; set; }

        public Guid QuestionId { get; set; }

        public string Body { get; set; }
    }
}
