using Proyecto_Final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace Proyecto_Final.Data
{
    public class RedadaService : IRedadaService
    {

        private readonly MigracionContext _context;

        public RedadaService(MigracionContext context)
        {
            _context = context;
        }
        public async Task<bool> AlterarRedada(Redada redada)
        {
            _context.Entry(redada).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> BorrarRedada(int id)
        {
            var redada = _context.Redadas.Find(id);
            _context.Redadas.Remove(redada);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> GuardarRedada(Redada redada)
        {
            if(redada.Id > 0)
            {
                return await AlterarRedada(redada);
            }
            else
            {
                return await NuevaRedada(redada);
            }

        }

        public async Task<bool> NuevaRedada(Redada redada)
        {
            _context.Redadas.Add(redada);

            return await _context.SaveChangesAsync()> 0;
        }

        public async Task<IEnumerable<Redada>> ObtenerRedadas()
        {
            return await _context.Redadas.ToListAsync();
		}

		public async Task<Redada> ObtenerRedadaPorId(int id)
		{
			return await _context.Redadas.FirstOrDefaultAsync(r => r.Id == id);
		}
	}
}
