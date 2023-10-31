using Dapper;
using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using Modelo.Repositorio;
using Servicio.Contexto;
using System.Data;


namespace Servicio.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private ClienteContexto clienteContexto;

        public ClienteRepositorio()
        {
            clienteContexto = new ClienteContexto();
        }

        public async Task<bool> AgregarCliente(ClienteModelo clienteModelo)
        {
            using (IDbConnection db = clienteContexto.connection)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@p_nombre", clienteModelo.nombre, DbType.String);
                parameters.Add("@p_apellido", clienteModelo.apellido, DbType.String);
                parameters.Add("@p_correo", clienteModelo.correo, DbType.String);
                parameters.Add("@p_telefono", clienteModelo.telefono, DbType.String);

                await db.ExecuteAsync("InsertarCliente", parameters, commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public async Task<List<ClienteEntidad>> ConsultarClientes()
        {
            using (IDbConnection db = clienteContexto.connection)
            {
                var result = await db.QueryAsync<ClienteEntidad>("ConsultarClientes", commandType: CommandType.StoredProcedure);
                List<ClienteEntidad> clientes = result.ToList();

                return clientes;
            }       
        }

        public async Task<bool> EliminarCliente(int cliente)
        {
            using (IDbConnection db = clienteContexto.connection)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@p_id_Cliente", cliente, DbType.String);


                await db.ExecuteAsync("EliminarCliente", parameters, commandType: CommandType.StoredProcedure);

                return true;
            }
        }
    }
}
