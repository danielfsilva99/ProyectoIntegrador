using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;


namespace Servicio.Contexto
{
    public class ClienteContexto 
    {
        private string connectionString;

        public ClienteContexto()
        {
            connectionString = "server=localhost\\SQLEXPRESS;database=master; integrated security=True; Trusted_Connection=True; TrustServerCertificate=True;";
        }

        public IDbConnection connection
        {
            get
            {

                return new SqlConnection(connectionString);
            }

        }

    }
}
