using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using Modelo.Repositorio;
using Servicio.Contexto;
using System.Data;
using Dapper;

namespace Servicio.Repositorio
{
    public class CuentasBancariasRepositorio : ICuentasBancariasRepositorio
    {
        private ClienteContexto clienteContexto;

        public CuentasBancariasRepositorio()
        {
            clienteContexto = new ClienteContexto();
        }
        public Task<bool> AgregarCuenta(CuentasBancariasModelo clienteModelo)
        {
            throw new NotImplementedException(); 
        }

        public async Task<List<CuentasBancariasEntidad>> ConsultarCuentas(int idCliente)
        {
            using (IDbConnection db = clienteContexto.connection)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id_cliente", idCliente, DbType.Int32);
                var result = await db.QueryAsync<CuentasBancariasEntidad>("ConsultarCuentasPorCliente",parameters, commandType: CommandType.StoredProcedure);
                List<CuentasBancariasEntidad> cuentas = result.ToList();

                return cuentas;
            }
        }

        public Task<bool> EliminarCuenta(int cuenta)
        {
            throw new NotImplementedException();
        }
    }
}
