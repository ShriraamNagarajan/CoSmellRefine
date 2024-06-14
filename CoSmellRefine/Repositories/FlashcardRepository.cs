using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class FlashcardRepository : IFlashcardRepository 
    {
        private readonly ApplicationDbContext dbContext;

        public FlashcardRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Flashcard Add(Flashcard flashcard)
        {
            dbContext.Add(flashcard);
            dbContext.SaveChanges();
            return flashcard;
        }

        public async Task<Flashcard?> DeleteAsync(Guid id)
        {
            var existingFlashcard = await dbContext.Flashcards.FindAsync(id);

            if (existingFlashcard != null)
            {
                dbContext.Flashcards.Remove(existingFlashcard);
                await dbContext.SaveChangesAsync();
                return existingFlashcard;
            }

            return null;
        }

        public async Task<IEnumerable<Flashcard>> GetAllAsync()
        {

            return await dbContext.Flashcards.ToListAsync();
        }

        public async Task<IEnumerable<Flashcard>> GetByModuleIdAsync(Guid moduleId)
        {
            return await dbContext.Flashcards
                .Where(flashcard => flashcard.ModuleId == moduleId)
                .ToListAsync();
        }


        public async Task<Flashcard?> GetAsync(Guid id)
        {
            return await dbContext.Flashcards
            .Include(x => x.Module)
            .FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<Flashcard?> UpdateAsync(Flashcard flashcard)
        {
            var existingFlashcard = await dbContext.Flashcards.Include(x => x.Module)
                .FirstOrDefaultAsync(x => x.Id == flashcard.Id);

            if (existingFlashcard != null)
            {
                existingFlashcard.Id = flashcard.Id;
                existingFlashcard.Question = flashcard.Question;
                existingFlashcard.Answer = flashcard.Answer;
                await dbContext.SaveChangesAsync();
                return existingFlashcard;
            }

            return null;
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.Flashcards.CountAsync();
        }



    }
}
