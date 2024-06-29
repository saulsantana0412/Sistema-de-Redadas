
using Proyecto_Final.Models;

namespace Proyecto_Final.Data
{
    public interface IRedadaService
    {
        Task<IEnumerable<Redada>> ObtenerRedadas();
        Task<bool> NuevaRedada(Redada redada);
        Task<bool> AlterarRedada(Redada redada);
        Task<bool> BorrarRedada(int id);
        Task<bool> GuardarRedada(Redada redada);
        Task<Redada> ObtenerRedadaPorId(int id);
	}
}
    