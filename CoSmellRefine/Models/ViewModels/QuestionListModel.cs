using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Models.ViewModels
{
    public class QuestionListModel
    {
        public IEnumerable<Question> Questions { get; set; }
        public int TotalPages { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? SortBy { get; set; }
        public string? QuestionType { get; set; }
        public string? FilterType { get; set; }
    }
}
