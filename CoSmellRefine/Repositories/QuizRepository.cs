using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly ApplicationDbContext dbContext;

        public QuizRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Quiz Add(Quiz quiz)
        {
            dbContext.Add(quiz);
            dbContext.SaveChanges();
            return quiz;
        }

        public async Task<Quiz?> DeleteAsync(Guid id)
        {
            var existingQuiz = await dbContext.Quiz.FindAsync(id);

            if (existingQuiz != null)
            {
                dbContext.Quiz.Remove(existingQuiz);
                await dbContext.SaveChangesAsync();
                return existingQuiz;
            }

            return null;
        }

        public async Task<IEnumerable<Quiz>> GetAllAsync()
        {

            return await dbContext.Quiz.ToListAsync();
        }

        public async Task<IEnumerable<Quiz>> GetByModuleIdAsync(Guid moduleId)
        {
            return await dbContext.Quiz
                .Where(quiz => quiz.ModuleId == moduleId)
                .ToListAsync();
        }


        public async Task<Quiz?> GetAsync(Guid id)
        {
            return await dbContext.Quiz
            .Include(x => x.Module)
            .FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<Quiz?> UpdateAsync(Quiz quiz)
        {
            var existingQuiz = await dbContext.Quiz.Include(x => x.Module)
                .FirstOrDefaultAsync(x => x.Id == quiz.Id);

            if (existingQuiz != null)
            {
                existingQuiz.Id = quiz.Id;
                existingQuiz.Question = quiz.Question;
                existingQuiz.Answer = quiz.Answer;
                existingQuiz.Choices = quiz.Choices;
                await dbContext.SaveChangesAsync();
                return existingQuiz;
            }

            return null;
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.Quiz.CountAsync();
        }

    }
}
