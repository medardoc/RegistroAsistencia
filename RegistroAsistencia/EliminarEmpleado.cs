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
    public partial class EliminarEmpleado : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void EliminarEmpleado_Load(object sender, EventArgs e)
        {
            // Puedes inicializar cosas si es necesario
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Empleados WHERE Nombre LIKE @Nombre"; // Ajusta la consulta según tus necesidades

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", "%" + txtConsultarEliminar.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewEliminar.DataSource = dataTable;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEliminar.SelectedRows.Count > 0)
            {
                // Supongamos que el ID del empleado es la primera columna
                int empleadoId = Convert.ToInt32(dataGridViewEliminar.SelectedRows[0].Cells[0].Value);

                string query = "DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                // Actualizar la vista después de la eliminación
                btnBuscarEliminar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
            }
        }


        public void btnRegresar1_Click(object sender, EventArgs e)
        {
            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }
    }
}
