using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
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


        public async Task<IEnumerable<Question>> GetAllAsync(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100)
        {
            var query = dbContext.Questions
                                 .Include(x => x.User)
                                 .Include(x => x.Images)
                                 .Include(x => x.CodeSmellList)
                                 .Include(x => x.RefactoringTechniques)
                                  .Include(x => x.Responses)
                                 .AsQueryable();

            // Filtering
            if (string.IsNullOrWhiteSpace(searchQuery) == false)
            {
                query = query.Where(x =>
                    (x.Title != null && x.Title.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.User.UserName != null && x.User.UserName.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.Status != null && x.Status.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.Type != null && x.Type.ToLower().Contains(searchQuery.ToLower())) 
                );
            }

            // Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);

                if (string.Equals(sortBy, "Title", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Title) : query.OrderBy(x => x.Title);
                }
                else if (string.Equals(sortBy, "User", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.User.UserName) : query.OrderBy(x => x.User.UserName);
                }
                else if (string.Equals(sortBy, "Status", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Status) : query.OrderBy(x => x.Status);
                }
                else if (string.Equals(sortBy, "Type", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Type) : query.OrderBy(x => x.Type);
                }
                else if (string.Equals(sortBy, "Responses", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Responses.Count) : query.OrderBy(x => x.Responses.Count);
                }
                else if (string.Equals(sortBy, "PostedDate", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.PostedDate) : query.OrderBy(x => x.PostedDate);
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

    }
}
