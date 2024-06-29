using CoSmellRefine.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace CoSmellRefine.Models.ViewModels
{
    public class QuestionDetailViewModel
    {
        public Question Question;

        public List<QuestionResponseViewModel> Responses;

        public AddResponseCommentViewModel AddResponseComment;  

        public AddReportIssueViewModel AddReportIssue;

        public AddResponseViewModel AddResponse;

    }
}
