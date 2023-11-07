using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    public interface IClienteRepositorio
    {
        public Task<List<ClienteEntidad>> ConsultarClientes();

        public Task<bool> AgregarCliente(ClienteModelo clienteModelo);

        public Task<bool> EliminarCliente(int cliente);

        public Task<ClienteEntidad> ConsultarCliente(int idCliente);
    }
}
