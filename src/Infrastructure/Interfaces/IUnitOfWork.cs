using System;
using System.Threading.Tasks;

namespace EventosNova.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository Events { get; }
        IFinanceRepository Finances { get; }
        IProviderRepository Providers { get; }
        Task<int> CommitAsync(); // Ejecuta la transacción global en la BD
    }
}
