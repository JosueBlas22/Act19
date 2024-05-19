namespace Directorio4E.Data
{
    public interface IRepositorio
    {
        Task<List<Persona>> GetAll();
        Task<Persona> Get(int id);
        Task<Persona> Add(Persona persona);
        Task Update(int id, Persona persona);
        Task Delete(int id);
        Task<List<Clasificacion>> GetAllClasificaciones();
        Task<Clasificacion> GetClasificacion(int id);
    }
}
