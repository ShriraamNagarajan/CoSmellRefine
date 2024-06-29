namespace CoSmellRefine.Models.ViewModels
{
    public class AddReportIssueViewModel
    {
        public Guid DiscussionItemId { get; set; }

        public Guid QuestionId { get; set; }

        public string Reason { get; set; }

        public string DiscussionType { get; set; }
    }
}
