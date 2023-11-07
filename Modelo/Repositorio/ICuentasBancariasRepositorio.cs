using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    public interface ICuentasBancariasRepositorio
    {
        public Task<List<CuentasBancariasEntidad>> ConsultarCuentas(int idCliente);

        public Task<bool> AgregarCuenta(CuentasBancariasModelo clienteModelo);

        public Task<bool> EliminarCuenta(int cuenta);
    }
}
