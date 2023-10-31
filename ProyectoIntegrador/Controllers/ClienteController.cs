using Microsoft.AspNetCore.Mvc;
using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using Servicio.Repositorio;

namespace ProyectoIntegrador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {

        public readonly ClienteRepositorio clienteRepositorio;

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
            clienteRepositorio = new ClienteRepositorio();
        }

        [HttpGet]
        public async Task<List<ClienteEntidad>> GetAll()
        {
            var clientes = await clienteRepositorio.ConsultarClientes();
            return clientes;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteModelo clienteModelo)
        {
            await clienteRepositorio.AgregarCliente(clienteModelo);
            
            return StatusCode(201); 
        }

        [HttpDelete("{clienteId}")]
        public async Task<IActionResult> Delete(int clienteId)
        {
            await clienteRepositorio.EliminarCliente(clienteId);

            return StatusCode(201);
        }

    }
}
