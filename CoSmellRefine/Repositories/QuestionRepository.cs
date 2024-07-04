using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
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

        public async Task<IEnumerable<Question>> GetRecentQuestionsAsync(string userId)
        {
            return await dbContext.Questions
                                 .Where(q => q.UserId == userId)
                                 .OrderByDescending(q => q.PostedDate)
                                 .Take(5) // or any number you want to show
                                 .ToListAsync();
        }
        public async Task<IEnumerable<Question>> GetRecentQuestionsAsync()
        {
            return await dbContext.Questions
                                 .OrderByDescending(q => q.PostedDate)
                                 .Take(5) // or any number you want to show
                                 .ToListAsync();
        }

        public ModeratorDiscussionSummaryViewModel GetQuestionsPerMonth()
        {
            var questions = dbContext.Questions
                                    .Where(q => !q.IsDeleted)
                                    .GroupBy(q => new { q.PostedDate.Year, q.PostedDate.Month })
                                    .Select(g => new
                                    {
                                        Year = g.Key.Year,
                                        Month = g.Key.Month,
                                        Count = g.Count()
                                    })
                                    .OrderBy(g => g.Year)
                                    .ThenBy(g => g.Month)
                                    .ToList();

            var viewModel = new ModeratorDiscussionSummaryViewModel
            {
                NumberOfQuestions = questions.Select(q => q.Count).ToList(),
                Months = questions.Select(q => new DateTime(q.Year, q.Month, 1).ToString("MMM yyyy")).ToList()
            };

            return viewModel;
        }

        public List<(string MonthYear, int OpenQuestions, int ClosedQuestions)> GetQuestionSummaryByMonth()
        {
            return dbContext.Questions
                           .GroupBy(q => new { q.PostedDate.Year, q.PostedDate.Month })
                           .Select(g => new
                           {
                               MonthYear = $"{g.Key.Month}/{g.Key.Year}",
                               OpenQuestions = g.Count(q => q.Status == QuestionStatus.Open),
                               ClosedQuestions = g.Count(q => q.Status == QuestionStatus.Closed)
                           })
                           .ToList()
                           .Select(q => (q.MonthYear, q.OpenQuestions, q.ClosedQuestions))
                           .ToList();
        }

    }
}
