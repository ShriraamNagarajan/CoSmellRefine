using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetAllAsync(string? sortBy, string? questionType, string? userId, int pageNumber = 1, int pageSize = 100);
        Question? Get(Guid id);

        Task<int> CountAsync();

        Task<Question?> DeleteAsync(Guid id);

        Question Add(Question question);

        void Update(Question question);

    }
}
