using ArquitecturaMicroservicio.Entities;

namespace  ArquitecturaMicroservicio.Repositories
{
    public interface IClienteRepository 
    {

        Task<Cliente> InsertarCliente(Cliente cliente);
        Task<Cliente> EditarCliente(Cliente cliente);
        Task<Cliente> BuscarPorId(int id);
        Task<Cliente> BuscarPorIdPersona(int id);
        Task<Cliente> EliminarCliente(Cliente cliente);

    }
}