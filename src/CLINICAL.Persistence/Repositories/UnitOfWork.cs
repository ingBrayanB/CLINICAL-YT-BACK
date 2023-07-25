using CLINICAL.Application.Interface.Interfaces;
using CLINICAL.Domain.Entities;

namespace CLINICAL.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Analysis> Analysis {get;}

        public UnitOfWork(IGenericRepository<Analysis> analysis)
        {
            Analysis = analysis;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}