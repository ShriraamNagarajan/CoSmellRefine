using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Models.ViewModels
{
    public class DeveloperDashboardViewModel
    {
        public IEnumerable<ModuleCompletion> ModuleCompletions { get; set; }
        public IEnumerable<Notification> Notifications { get; set; }
        public IEnumerable<Question> RecentQuestions { get; set; }

        public List<string> QuestionMonths { get; set; }
        public List<int> OpenQuestions { get; set; }
        public List<int> ClosedQuestions { get; set; }


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
