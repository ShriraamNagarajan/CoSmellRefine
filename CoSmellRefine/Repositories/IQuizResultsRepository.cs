using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IQuizResultsRepository
    {
        QuizResults Add(QuizResults result);

        Task<IEnumerable<QuizResults>> GetAllAsync();

        Task<IEnumerable<QuizResults>> GetUserAsync(string userId);


        Task<QuizResults> GetQuizResultsAsync(Guid moduleId, string userId);

        void Update(QuizResults result);    
    }
}
