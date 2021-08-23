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

            string connectionString = "Data Source=DESKTOP-2IDJVON\\SQLEXPRESS01;Initial Catalog=bdFutbol;User ID=sa;Password=michael";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}