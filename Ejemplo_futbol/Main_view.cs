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
using System.Collections;
using QRCoder;


namespace Ejemplo_futbol
{
    public partial class Main_view : Form
    {
        private SqlConnection connection;
        private DataTable table;
        public Main_view()
        {
            
            InitializeComponent();
            table = new DataTable();

            connection = Connection.conectar();

            connection.Open();
            SqlDataAdapter data_adapter = new SqlDataAdapter("select * from ligas", connection);
            
            data_adapter.Fill(table);

            connection.Close();
            liga_box.ValueMember = "codLiga";
            liga_box.DisplayMember = "nomLiga";
            liga_box.DataSource = table;
            connection.Open();
            table = new DataTable();
            SqlCommand command = new SqlCommand("select * from dbo.equipos_liga(@equipo)", connection);

            command.Parameters.AddWithValue("@equipo", liga_box.SelectedValue);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            dataGridView1.DataSource = table;
            connection.Close();
           
            // rellenar_tabla();


        }




       
       
        private void event_liga_index_changed(object sender, EventArgs e)
        {
            rellenar_tabla();
            
            

        }
        private void rellenar_tabla()
        {
            dataGridView1.Columns.Clear();

            Console.WriteLine("asdasdasd");
            connection.Open();
            table = new DataTable();
            SqlCommand command = new SqlCommand("select * from dbo.equipos_liga(@equipo)", connection);

            command.Parameters.AddWithValue("@equipo", liga_box.SelectedValue);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Nombre equipo";
            connection.Close();
           
            DataGridViewButtonColumn buttons_column = new DataGridViewButtonColumn();
            buttons_column.Name = "QR";
            buttons_column.Text = "generar QR";
            buttons_column.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttons_column);
            
        }
       

        private void button_consulta_contratos_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand proc_consulta_contratos_command = new SqlCommand("consulta_contratos", connection);
                proc_consulta_contratos_command.CommandType = CommandType.StoredProcedure;

                SqlParameter param_equipo = new SqlParameter("@equipo", SqlDbType.Int);
                param_equipo.Direction = ParameterDirection.Input;
                param_equipo.Value = Int32.Parse( box_equipo.Text);

                SqlParameter param_precio_anual = new SqlParameter("@precio_anual", SqlDbType.Int);
                param_precio_anual.Direction = ParameterDirection.Input;
                param_precio_anual.Value = Int32.Parse(box_precio_anual.Text);

                SqlParameter param_precio_recision = new SqlParameter("@precio_recision", SqlDbType.Int);
                param_precio_recision.Direction = ParameterDirection.Input;
                param_precio_recision.Value = Int32.Parse(box_precio_recision.Text);

                SqlParameter param_futbolistas_activos_out = new SqlParameter("@futbolistas_activos", SqlDbType.Int);
                param_futbolistas_activos_out.Direction = ParameterDirection.Output;


                SqlParameter param_futbolistas_condiciones_out = new SqlParameter("@futbolistas_activos_condiciones", SqlDbType.Int);
                param_futbolistas_condiciones_out.Direction = ParameterDirection.Output;

                SqlParameter[] parameters = { param_equipo, param_precio_anual, param_precio_recision,
                                          param_futbolistas_activos_out, param_futbolistas_condiciones_out };


                proc_consulta_contratos_command.Parameters.AddRange(parameters);
                proc_consulta_contratos_command.ExecuteNonQuery();
                connection.Close();

                label_futbolistas_activos.Text = param_futbolistas_activos_out.Value.ToString();
                label_condiciones.Text = param_futbolistas_condiciones_out.Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Datos erroneos, introduzcalos de nuevo");
                box_equipo.Text = "";
                box_precio_anual.Text = "";
                box_precio_recision.Text = "";
                label_futbolistas_activos.Text = "";
                label_condiciones.Text = "";
            }



        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 1)
            {
               
                String qr_string = "";

                foreach (Object field in table.Rows[e.RowIndex].ItemArray)
                {
                    qr_string += field.ToString() + " ";
                }
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr_string, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(7);

                new QRview(qrCodeImage).Show();
            }
        }


    }
}
