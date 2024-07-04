using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Models.ViewModels
{
    public class AdminDashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalQuestionsPosted { get; set; }
        public int TotalModules { get; set; }
        public string RecentlyUpdatedModule { get; set; }
        public List<string> TopContributors { get; set; }
        public List<int> Contributions { get; set; }
        public IEnumerable<ModuleCompletion> ModuleCompletions { get; set; }
        public List<string> QuestionMonths { get; set; }
        public List<int> OpenQuestions { get; set; }
        public List<int> ClosedQuestions { get; set; }
        public List<string> QuizResultModules { get; set; }
        public List<double> AverageQuizResults { get; set; }
    }
}
