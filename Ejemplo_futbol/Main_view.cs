using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejemplo_futbol
{
    public partial class Main_view : Form
    {
        private SqlConnection connection;
        public Main_view()
        {
            InitializeComponent();

            connection = Connection.conectar();

            connection.Open();
            SqlDataAdapter data_adapter = new SqlDataAdapter("select * from ligas", connection);
            DataTable table = new DataTable();
            
            data_adapter.Fill(table);
            liga_box.ValueMember = "codLiga";
            liga_box.DisplayMember = "nomLiga";
            liga_box.DataSource = table;
            connection.Close();
     
        }

        private void mostrar_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select * from dbo.equipos_liga(@equipo)", connection);

            command.Parameters.AddWithValue("@equipo", liga_box.SelectedValue);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            dataGridView1.DataSource = table;
            connection.Close();


        }
    }
}
