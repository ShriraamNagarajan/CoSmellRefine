using CoSmellRefine.Models.Domain;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.ViewModels
{
    public class ModuleViewModel
    {
        public Guid Id { get; set; }
        public Guid CodeSmellId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReadingContent { get; set; }
        public List<string> VideoUrls { get; set; }
        public List<FlashcardViewModel> Flashcards { get; set; }
        public List<QuizViewModel> Quizzes { get; set; }

        [ValidateNever]
        public IEnumerable<CodeSmell> CodeSmells { get; set; }

        public ModuleViewModel()
        {
            VideoUrls = new List<string>();
            Flashcards = new List<FlashcardViewModel>();
            Quizzes = new List<QuizViewModel>();
        }
    }
}
