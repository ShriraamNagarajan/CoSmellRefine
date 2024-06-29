namespace CoSmellRefine.Models.ViewModels
{
    public class LearnDashboardViewModel
    {
        public int CompletedModules { get; set; }
        public int TotalModules { get; set; }
        public double AverageQuizScore { get; set; }
        public double Progress { get; set; }

        public List<double> QuizScores { get; set; }
        public List<DateTime> QuizDates
        {
            get; set;
        }

    }
}
