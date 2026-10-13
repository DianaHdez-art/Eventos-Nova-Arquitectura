using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventosNova.Infrastructure.Interfaces
{
    public interface IEventRepository : IRepository<Object>
    {
        Task<IEnumerable<Object>> GetByClientAsync(string clienteId);
        Task<IEnumerable<Object>> GetByDateRangeAsync(DateTime inicio, DateTime fin);
    }
}
