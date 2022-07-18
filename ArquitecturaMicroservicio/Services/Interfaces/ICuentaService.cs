
using ArquitecturaMicroservicio.Dto;

namespace ArquitecturaMicroservicio.Services
{
    public interface ICuentaService 
    {
        Task<int> CrearCuenta(CuentaDto cuentaDto);
        Task<int> EditarCuenta(CuentaDto cuentaDto);
        Task<bool> EliminarCuenta(string numCuenta);
        Task<CuentaDto> ObtenerCuenta(string numCuenta);
    }
}