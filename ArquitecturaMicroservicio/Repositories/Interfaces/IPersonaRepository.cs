using ArquitecturaMicroservicio.Entities;

namespace  ArquitecturaMicroservicio.Repositories
{
    public interface IPersonaRepository 
    {
        Task<Persona> BuscarPorIdentificacion(string identificacion);
        Task<Persona> InsertarPersona(Persona persona);
        Task<Persona> EditarPersona(Persona persona);
        Task<Persona> EliminarPersona(Persona persona);
        Task<Persona> ObtenerPersona(string identificacion);
        Task<Persona> BuscarPorId(int id);
    }
}