using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ModeloEntrada
{
    public class CuentasBancariasEntidad
    {
        public int id_cuenta { get; set; }

        public int id_cliente { get; set; }

        public string tipo_cuenta { get; set; }

        public float saldo { get; set; }
    }
}
