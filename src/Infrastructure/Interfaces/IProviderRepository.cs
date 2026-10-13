using System.Threading.Tasks;

namespace EventosNova.Infrastructure.Interfaces
{
    public interface IProviderRepository : IRepository<Object>
    {
        Task<int> CountActiveAssignmentsByEventAsync(string eventoId); // Valida el límite de 15 proveedores
        Task<bool> ValidateResponseWindowAsync(string proveedorId);   // Valida las 48 horas
    }
}
