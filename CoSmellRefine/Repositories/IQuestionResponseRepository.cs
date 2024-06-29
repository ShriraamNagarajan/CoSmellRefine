using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IQuestionResponseRepository
    {
        Task<IEnumerable<QuestionResponse>> GetByQuestionId(Guid id);
        QuestionResponse? Get(Guid id);
        Task<QuestionResponse?> DeleteAsync(Guid id);

        QuestionResponse Add(QuestionResponse questionResponse);    
    }
}
