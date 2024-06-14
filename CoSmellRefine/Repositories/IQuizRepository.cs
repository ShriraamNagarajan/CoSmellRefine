using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IQuizRepository
    {
        Task<IEnumerable<Quiz>> GetAllAsync();

        Task<IEnumerable<Quiz>> GetByModuleIdAsync(Guid moduleId);
        Task<Quiz?> GetAsync(Guid id);

        Quiz Add(Quiz quiz);

        Task<Quiz?> UpdateAsync(Quiz quiz);

        Task<Quiz?> DeleteAsync(Guid id);

        Task<int> CountAsync();
    }
}
