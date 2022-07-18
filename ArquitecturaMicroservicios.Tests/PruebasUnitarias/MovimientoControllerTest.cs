using ArquitecturaMicroservicio.Controller;
using ArquitecturaMicroservicio.Entities;
using ArquitecturaMicroservicio.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaMicroservicios.Tests.PruebasUnitarias
{

    [TestClass]
    public class MovimientoControllerTest: BasePruebas
    {
        private readonly IMovimientoService _movimientoService;
        public MovimientoControllerTest(IMovimientoService movimientoService)
        {
            _movimientoService = movimientoService;
        }
        [TestMethod]
        public async Task ObtenerMovimientos()
        {
            // Preparación
            

            // Prueba

            var controller = new MovimientoController(_movimientoService);
            var respuesta = await  controller.ObtenerMovimiento(1);

            // Verificación
            var movimientos = respuesta;
            Assert.AreEqual(4, movimientos.Equals(4));
        }
    }
}
