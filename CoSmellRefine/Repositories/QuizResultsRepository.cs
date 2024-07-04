using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class QuizResultsRepository : IQuizResultsRepository
    {
        private readonly ApplicationDbContext dbContext;

        public QuizResultsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public QuizResults Add(QuizResults result)
        {
            dbContext.Add(result);
            dbContext.SaveChanges();
            return result;
        }

        public async Task<IEnumerable<QuizResults>> GetAllAsync() {
            return await dbContext.QuizResults
                .Include(x => x.Module)
                .Include(x => x.User)
                .ToListAsync();
        
        }


        public async Task<IEnumerable<QuizResults>> GetUserAsync(string userId)
        {
            return await dbContext.QuizResults
                .Include(x => x.Module)
                .Include(x => x.User)
                .Where(x => x.UserId == userId)
                .ToListAsync();

        }

        public async Task<QuizResults> GetQuizResultsAsync(Guid moduleId, string userId)
        {
            return await dbContext.QuizResults
                .Include(x => x.Module)
                .Include(x => x.User)
                .FirstOrDefaultAsync(qr => qr.ModuleId == moduleId && qr.UserId == userId);
        }


        public void Update(QuizResults result)
        {
            dbContext.QuizResults.Update(result);
            dbContext.SaveChanges();
        }

        public List<(string ModuleName, double AverageResult)> GetAverageQuizResults()
        {
            return dbContext.QuizResults
                           .GroupBy(qr => qr.ModuleId)
                           .Select(g => new
                           {
                               ModuleName = g.FirstOrDefault().Module.Title,
                               AverageResult = g.Average(qr => qr.Result)
                           })
                           .ToList()
                           .Select(qr => (qr.ModuleName, qr.AverageResult))
                           .ToList();
        }
    }
}
