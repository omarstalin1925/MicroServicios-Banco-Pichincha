
namespace  ArquitecturaMicroservicio.Dto
{
    public partial class CuentaDto
    {
        public CuentaDto()
        {
            Movimiento = new HashSet<MovimientoDto>();
        }

        public int CuentaId { get; set; }
        public int ClienteId { get; set; }
        public string NumCuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public decimal SaldoInicial { get; set; }
        public bool Estado { get; set; }

        public virtual ClienteDto Cliente { get; set; } = null!;
        public virtual ICollection<MovimientoDto> Movimiento { get; set; }
    }
}
