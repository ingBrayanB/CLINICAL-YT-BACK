using CLINICAL.Domain.Entities;

namespace CLINICAL.Application.Interface
{
    public interface IAnalysisRepository
    {
        Task<IEnumerable<Analysis>> ListAnalysis();
    }
}