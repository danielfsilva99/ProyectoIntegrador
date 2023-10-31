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
        Task <List<ClienteEntidad>> ConsultarClientes();

        Task<bool> AgregarCliente(ClienteModelo clienteModelo);

        Task<bool> EliminarCliente(int cliente);
    }
}
