using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;

namespace CoSmellRefine.Repositories
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetAllAsync(string? sortBy, string? questionType, string? userId, int pageNumber = 1, int pageSize = 100);
        Task<IEnumerable<Question>> GetAllAsyncModerator(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100);
        Question? Get(Guid id);

        Task<int> CountAsync();

        Task<Question?> DeleteAsync(Guid id);

        Question Add(Question question);

        void Update(Question question);

        Task<IEnumerable<Question>> GetRecentQuestionsAsync(string userId);

        Task<IEnumerable<Question>> GetRecentQuestionsAsync();

        ModeratorDiscussionSummaryViewModel GetQuestionsPerMonth();
        List<(string MonthYear, int OpenQuestions, int ClosedQuestions)> GetQuestionSummaryByMonth();
        List<(string MonthYear, int OpenQuestions, int ClosedQuestions)> GetDeveloperQuestionSummaryByMonth(string userId);
    }
}
