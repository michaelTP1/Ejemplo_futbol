using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo_futbol
{
    class Connection
    {
        public static SqlConnection conectar()
        {

            string connection_string = "Data Source=DESKTOP-OEVSSQ4, 1433;Initial Catalog=bdFutbol;User ID=sa;Password=sa";
            SqlConnection connection = new SqlConnection(connection_string);
            return connection;
        }
    }
}