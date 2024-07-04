using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Models.ViewModels
{
    public class ModeratorDashboardViewModel
    {
        public ModeratorDiscussionSummaryViewModel DiscussionSummary { get; set; }
        public ModeratorReportIssueSummaryViewModel ReportIssueSummary { get; set; }   
        public IEnumerable<Notification> Notifications { get; set; }
        public IEnumerable<Question> RecentQuestions { get; set; }


        public string GetTimeDifference(DateTime sentTime)
        {
            var timeSpan = DateTime.Now - sentTime;
            if (timeSpan.TotalMinutes < 1)
                return "Just now";
            if (timeSpan.TotalMinutes < 60)
                return $"{timeSpan.Minutes} minutes ago";
            if (timeSpan.TotalHours < 24)
                return $"{timeSpan.Hours} hours ago";
            if (timeSpan.TotalDays < 7)
                return $"{timeSpan.Days} days ago";
            if (timeSpan.TotalDays < 30)
                return $"{timeSpan.Days / 7} weeks ago";
            if (timeSpan.TotalDays < 365)
                return $"{timeSpan.Days / 30} months ago";

            return $"{timeSpan.Days / 365} years ago";
        }
    }
}
