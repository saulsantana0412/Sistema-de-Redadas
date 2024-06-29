using Proyecto_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Final.Data
{
    public class PersonaService : IPersonaService
    {

        private readonly MigracionContext _context;

        public PersonaService(MigracionContext context)
        {
            _context = context;
        }
        public async Task<bool> AlterarPersona(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> BorrarPersona(int id)
        {
            var persona = _context.Personas.Find(id);
            _context.Personas.Remove(persona);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> GuardarPersona(Persona persona)
        {
            if (persona.Id > 0)
            {
                return await NuevaPersona(persona);
            }
            else
            {
                return await NuevaPersona(persona);
            }

        }

        public async Task<bool> NuevaPersona(Persona persona)
        {
            _context.Personas.Add(persona);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Persona>> ObtenerPersonas(int id)
        {
            return await _context.Personas.Where(p => p.Id_Redada == id).ToListAsync();
        }

        public async Task<IEnumerable<Persona>> ObtenerPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

        public int CantidadPersonas(int id)
        {
            return _context.Personas.Count(r => r.Id_Redada == id);
        }

        public async Task AgregarFilaPersona(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
        }

        public async Task<int> Guardar()
        {
            return await _context.SaveChangesAsync();
        }

        public int CantidadDinero(int id)
        {
            return _context.Personas
                    .Where(p => p.Id_Redada == id)
                    .Sum(p => p.Dinero);
        }

        public string? Redada(int id)
        {
            return (from p in _context.Personas
                    join r in _context.Redadas on p.Id_Redada equals r.Id
                    where r.Id == id
                    select r.Nombre).FirstOrDefault();


        }

        public async Task<bool> BorrarPersonas(List<Persona> personas)
        {
            _context.Personas.RemoveRange(personas);
            return await _context.SaveChangesAsync() >0;
        }
    }
}
