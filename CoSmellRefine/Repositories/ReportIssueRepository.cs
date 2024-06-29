using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class ReportIssueRepository : IReportIssueRepository
    {
        private readonly ApplicationDbContext dbContext;
        public ReportIssueRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<ReportIssue>> GetAllAsync(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100)
        {
            var query = dbContext.ReportIssues
                                 .Include(x => x.User)
                                 .AsQueryable();

            // Filtering
            if (string.IsNullOrWhiteSpace(searchQuery) == false)
            {
                query = query.Where(x =>
                    (x.User.UserName != null && x.User.UserName.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.Status != null && x.Status.ToLower().Contains(searchQuery.ToLower())) 
                );
            }

            // Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);

                if (string.Equals(sortBy, "Status", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Status) : query.OrderBy(x => x.Status);
                }
                else if (string.Equals(sortBy, "User", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.User.UserName) : query.OrderBy(x => x.User.UserName);
                }
      
                else if (string.Equals(sortBy, "ReportDate", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.ReportDate) : query.OrderBy(x => x.ReportDate);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;
            query = query.Skip(skipResults).Take(pageSize);

            return await query.ToListAsync();
        }


        public async Task<ReportIssue?> GetAsync(Guid id)
        {
            return await dbContext.ReportIssues
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<int> CountAsync()
        {
            return await dbContext.ReportIssues.CountAsync();
        }

        public async Task<ReportIssue?> UpdateAsync(ReportIssue issue)
        {
                dbContext.ReportIssues.Update(issue);
                await dbContext.SaveChangesAsync();
                return issue;
        }

        public ReportIssue Add(ReportIssue issue)
        {
            dbContext.Add(issue);
            dbContext.SaveChanges();
            return issue;
        }
    }
}
