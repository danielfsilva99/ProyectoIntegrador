using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Modelo.ModeloEntrada;

namespace Aplicacion.Mensajes
{
    public class ConsultarClientesMensaje : IRequest<List<ClienteEntidad>>
    {

    }
}
