namespace CoSmellRefine.Models.ViewModels
{
    public class QuizViewModel
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public string Answer { get; set; }

        public QuizViewModel()
        {
            Choices = new List<string>();
        }
    }
}
