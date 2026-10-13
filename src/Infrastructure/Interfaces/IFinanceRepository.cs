using System.Threading.Tasks;

namespace EventosNova.Infrastructure.Interfaces
{
    public interface IFinanceRepository : IRepository<Object>
    {
        Task<Object> GetByEventIdAsync(string eventoId);
        Task<Object> GetContractByDetailsAsync(string contratoId);
    }
}
