
using ArquitecturaMicroservicio.Dto;

namespace ArquitecturaMicroservicio.Services
{

    public interface IClienteService 
    {
        Task<int> CrearCliente(UsuarioDto usuarioDto);
        Task<int> EditarCliente(UsuarioDto usuarioDto);
        Task<bool> EliminarCliente(string identificacion);
        Task<PersonaDto> ObtenerCliente(string identificacion);

    }
}