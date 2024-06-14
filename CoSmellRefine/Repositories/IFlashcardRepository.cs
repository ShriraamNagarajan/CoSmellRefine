using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IFlashcardRepository
    {
        Task<IEnumerable<Flashcard>> GetAllAsync();

        Task<IEnumerable<Flashcard>> GetByModuleIdAsync(Guid moduleId);

        Task<Flashcard?> GetAsync(Guid id);

        Flashcard Add(Flashcard flashcard);

        Task<Flashcard?> UpdateAsync(Flashcard flashcard);

        Task<Flashcard?> DeleteAsync(Guid id);
        Task<int> CountAsync();

    }
}
