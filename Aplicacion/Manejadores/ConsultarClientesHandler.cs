using Aplicacion.Mensajes;
using MediatR;
using Modelo.ModeloEntrada;
using Modelo.Repositorio;
using Servicio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Manejadores
{
    public class ConsultarClientesHandler : IRequestHandler<ConsultarClientesMensaje, List<ClienteEntidad>>
    {
        private IClienteRepositorio clienteRepositorio;

        public ConsultarClientesHandler(IClienteRepositorio cliente) { 
        
            this.clienteRepositorio = cliente;
        }
        public async Task<List<ClienteEntidad>> Handle(ConsultarClientesMensaje request, CancellationToken cancellationToken)
        {
            List<ClienteEntidad> clientes = await clienteRepositorio.ConsultarClientes();
            return clientes;
        }
    }
}
