using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class QuestionResponseRepository : IQuestionResponseRepository
    {
        private readonly ApplicationDbContext dbContext;

        public QuestionResponseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public QuestionResponse? Get(Guid id)
        {
            return dbContext.Responses
                                 .Include(x => x.User)
                                 .Include(x => x.CodeSmellList)
                                 .Include(x => x.RefactoringTechniques)
                                 .Include(x => x.Votes)
                                 .FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<QuestionResponse>> GetByQuestionId(Guid id)
        {
            return await dbContext.Responses
                                 .Include(x => x.User)
                                 .Include(x => x.CodeSmellList)
                                 .Include(x => x.RefactoringTechniques)
                                 .Include(x => x.Votes)
                                 .Where(x => x.QuestionId == id)
                                 .ToListAsync();
        }



        public async Task<QuestionResponse?> DeleteAsync(Guid id)
        {
            var existingResponse = await dbContext.Responses.FindAsync(id);

            if (existingResponse != null)
            {
                existingResponse.IsDeleted = true;  
                await dbContext.SaveChangesAsync();
                return existingResponse;
            }

            return null;
        }

        public QuestionResponse Add(QuestionResponse questionResponse)
        {
            dbContext.Add(questionResponse);
            dbContext.SaveChanges();
            return questionResponse; 
        }

    }
}
