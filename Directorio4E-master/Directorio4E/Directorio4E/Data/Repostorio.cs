
using Microsoft.EntityFrameworkCore;

namespace Directorio4E.Data
{
    public class Repostorio : IRepositorio
    {
        private readonly DirectorioDBContext _contexto;

        public Repostorio(DirectorioDBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Persona> Add(Persona persona)
        {
            await _contexto.Personas.AddAsync(persona);
            await _contexto.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            Persona? persona = await _contexto.Personas.FindAsync(id);
            _contexto.Personas.Remove(persona!);
            await _contexto.SaveChangesAsync();
        }

        public async Task<Persona> Get(int id)
        {
            return await _contexto.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _contexto.Personas.Include(r => r.Clasificacion).ToListAsync();
        }

        public Task<List<Clasificacion>> GetAllClasificaciones()
        {
            return _contexto.Clasificaciones.ToListAsync();
        }

        public async Task<Clasificacion> GetClasificacion(int id)
        {
            return await _contexto.Clasificaciones.Include(r=>r.Personas).FirstAsync(c => c.Id == id);
        }

        public async Task Update(int id, Persona persona)
        {
            Persona personalocal = await _contexto.Personas.FindAsync(id);
            personalocal.Nombre = persona.Nombre;
            personalocal.Correo = persona.Correo;
            personalocal.Telefono = persona.Telefono;
            await _contexto.SaveChangesAsync();
        }


    }
}
