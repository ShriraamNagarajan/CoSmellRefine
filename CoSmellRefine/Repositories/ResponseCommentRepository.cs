using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class ResponseCommentRepository : IResponseCommentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ResponseCommentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ResponseComment? Get(Guid id)
        {
            return dbContext.ResponseComments
                                 .Include(x => x.User)
                                 .Include(x => x.Response)
                                 .FirstOrDefault(x => x.Id == id);
        }


        public async Task<ResponseComment?> DeleteAsync(Guid id)
        {
            var existingComment = await dbContext.ResponseComments.FindAsync(id);

            if (existingComment != null)
            {
                existingComment.IsDeleted = true;
                await dbContext.SaveChangesAsync();
                return existingComment;
            }

            return null;
        }

        public IEnumerable<ResponseComment> GetByResponseId(Guid id)
        {
            return dbContext.ResponseComments
                                 .Include(x => x.User)
                                 .Include(x => x.Response)
                                 .Where(x => x.ResponseId == id)
                                 .ToList();
        }


        public ResponseComment Add(ResponseComment comment)
        {
            dbContext.Add(comment);
            dbContext.SaveChanges();
            return comment;
        }

    }
}
