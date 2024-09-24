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
using System.Configuration;

namespace RegistroAsistencia
{
    public partial class ConsultarEmpleado : Form
    {
        public ConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void ConsultarEmpleado_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos iniciales si es necesario
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the connection string
                string connectionString = ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

                // Create the SQL query
                string query = "SELECT * FROM Empleados WHERE Nombre = @Nombre AND Apellido = @Apellido AND Rut = @Rut";

                // Use SqlConnection and SqlDataAdapter to fill the DataGridView
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", txtNombreConsultar.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellidoConsultar.Text);
                    command.Parameters.AddWithValue("@Rut", txtRutConsultar.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewCosnultar.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                MessageBox.Show("Error al consultar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}