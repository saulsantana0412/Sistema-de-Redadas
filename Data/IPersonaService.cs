
using Proyecto_Final.Models;

namespace Proyecto_Final.Data
{
    public interface IPersonaService
	{
        Task<IEnumerable<Persona>> ObtenerPersonas(int id);
		Task<IEnumerable<Persona>> ObtenerPersonas();
		Task<bool> NuevaPersona(Persona persona);
        Task<bool> AlterarPersona(Persona persona);
        Task<bool> BorrarPersona(int id);
        Task<bool> GuardarPersona(Persona persona);
		public int CantidadPersonas(int id);
		public int CantidadDinero(int id);
		public string Redada(int id);
		Task<bool> BorrarPersonas(List<Persona> personas);
		Task<int> Guardar();
		Task AgregarFilaPersona(Persona persona);

	}
}
    