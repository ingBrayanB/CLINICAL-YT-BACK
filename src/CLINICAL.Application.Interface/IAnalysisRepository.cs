using CLINICAL.Domain.Entities;

namespace CLINICAL.Application.Interface
{
    public interface IAnalysisRepository
    {
        Task<IEnumerable<Analysis>> ListAnalysis();
        Task<Analysis> AnalysisById(int analysisId);
        Task<bool> AnalysisRegister(Analysis analysis);
        Task<bool> AnalysisEdit(Analysis analysis);
        Task<bool> AnalysisRemove(int analysisId);
    }
}