using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IResponseCommentRepository
    {
        ResponseComment? Get(Guid id);
        Task<ResponseComment?> DeleteAsync(Guid id);
        IEnumerable<ResponseComment> GetByResponseId(Guid id);
        ResponseComment Add(ResponseComment comment);
    }
}
