using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using Servicio.Repositorio;

namespace ProyectoIntegrador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuentasBancariasController : Controller
    {

        public readonly CuentasBancariasRepositorio cuentasRepositorio;

        private readonly ILogger<ClienteController> _logger;

        public CuentasBancariasController(ILogger<ClienteController> logger)
        {
            _logger = logger;
            cuentasRepositorio = new CuentasBancariasRepositorio();
        }

        [HttpGet("{clienteId}")]
        public async Task<List<CuentasBancariasEntidad>> GetCuentasCliente(int clienteId)
        {
            var clientes = await cuentasRepositorio.ConsultarCuentas(clienteId);
            return clientes;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CuentasBancariasModelo cuentaModelo)
        {
            await cuentasRepositorio.AgregarCuenta(cuentaModelo);

            return StatusCode(201);
        }

        [HttpDelete("{cuentaId}")]
        public async Task<IActionResult> Delete(int cuentaId)
        {
            await cuentasRepositorio.EliminarCuenta(cuentaId);

            return StatusCode(201);
        }

    }
}
