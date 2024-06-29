using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using CoSmellRefine.Utility;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext dbContext;

        public QuestionRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IEnumerable<Question>> GetAllAsync(string? sortBy, string? questionType, string? userId, int pageNumber = 1, int pageSize = 100)
        {
            var query = dbContext.Questions
                                 .Include(x => x.User)
                                 .Include(x => x.Images)
                                 .Include(x => x.CodeSmellList)
                                 .Include(x => x.RefactoringTechniques)
                                 .Include(x => x.Responses)
                                 .AsQueryable();
         
            // Filtering by userId
            if (!string.IsNullOrWhiteSpace(userId))
            {
                query = query.Where(x => x.UserId == userId);
            }

            // Filtering
            if (!string.IsNullOrWhiteSpace(questionType))
            {
                if (string.Equals(questionType, "CodeSmellIdentification", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x => x.Type == QuestionType.CodeSmellIdentification);
                }
                else if (string.Equals(questionType, "RefactoringTechniqueIdentification", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x => x.Type == QuestionType.RefactoringTechniqueIdentification);
                }
                else if (string.Equals(questionType, "Both", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x => x.Type == QuestionType.CodeSmellIdentification
                                              || x.Type == QuestionType.RefactoringTechniqueIdentification);
                }
            }

            // Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {

                if (string.Equals(sortBy, "Responses", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.OrderByDescending(x => x.Responses.Count);
                }
                else if (string.Equals(sortBy, "PostedDate", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.OrderByDescending(x => x.PostedDate);
                }
               
                // Add other sorting conditions here if needed
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;
            query = query.Skip(skipResults).Take(pageSize);

            return await query.ToListAsync();
        }

        public Question? Get(Guid id)
        {
            return dbContext.Questions
                                 .Include(x => x.User)
                                 .Include(x => x.Images)
                                 .Include(x => x.CodeSmellList)
                                 .Include(x => x.RefactoringTechniques)
                                 .Include(x => x.Responses)
                                 .FirstOrDefault(x => x.Id == id);
        }


        public async Task<int> CountAsync()
        {
            return await dbContext.Questions.CountAsync();
        }

        public async Task<Question?> DeleteAsync(Guid id)
        {
            var existingQuestion = await dbContext.Questions.FindAsync(id);

            if (existingQuestion != null)
            {
                existingQuestion.IsDeleted = true;
                await dbContext.SaveChangesAsync();
                return existingQuestion;
            }

            return null;
        }

        public Question Add(Question question)
        {
            dbContext.Add(question);
            dbContext.SaveChanges();
            return question;
        }


        public void Update(Question question)
        {
            dbContext.Questions.Update(question);
            dbContext.SaveChanges();
        }

    }
}
