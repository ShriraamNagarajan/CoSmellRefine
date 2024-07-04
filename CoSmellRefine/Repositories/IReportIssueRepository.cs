using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;

namespace CoSmellRefine.Repositories
{
    public interface IReportIssueRepository
    {
        Task<IEnumerable<ReportIssue>> GetAllAsync(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100);
        Task<ReportIssue?> GetAsync(Guid id);
        Task<int> CountAsync();
        Task<ReportIssue?> UpdateAsync(ReportIssue issue);
        ReportIssue Add(ReportIssue issue);
        ModeratorReportIssueSummaryViewModel GetIssuesPerMonth();
    }
}
