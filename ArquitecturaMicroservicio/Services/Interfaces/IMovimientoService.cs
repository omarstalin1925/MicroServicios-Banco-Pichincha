
using ArquitecturaMicroservicio.Dto;

namespace ArquitecturaMicroservicio.Services
{
    public interface IMovimientoService 
    {
        Task<ResultadoDto> CrearMovimiento(MovimientoDto movimientoDto);
        Task<ResultadoDto> EditarMovimiento(MovimientoDto movimientoDto);
        Task<ResultadoDto> EliminarMovimiento(int id);
        Task<ResultadoDto> ObtenerMovimiento(int id);
        Task<List<ReporteMovimientoDto>> ObtenerListadoMovimientos(string fechaInicial, string fechaFinal, string identificacion);
    }
}