using Microsoft.EntityFrameworkCore;

namespace Directorio4E.Data
{
    public class DirectorioDBContext : DbContext
    {
        public DirectorioDBContext(DbContextOptions<DirectorioDBContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
    }
}
