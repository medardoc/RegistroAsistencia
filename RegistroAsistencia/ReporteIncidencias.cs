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
    public partial class ReporteIncidencias : Form
    {
        private SqlConnection connection;
        public ReporteIncidencias()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            // Cambia esta cadena de conexión según tu configuración
            string connectionString = ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        private void btnAgregarIncidencia_Click(object sender, EventArgs e)
        {
            string empleadoId = txtEmpleadoIDIncidencias.Text;
            string fecha = txtFechaIncidencia.Text;
            string descripcion = txtDescripcionI.Text;

            string query = @"INSERT INTO Incidencias (EmpleadoID, Fecha, Descripcion) 
                             VALUES (@EmpleadoID, @Fecha, @Descripcion)";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpleadoID", empleadoId);
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Incidencia agregada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la incidencia.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la incidencia: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnMostrarIncidencias_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Incidencias";

            try
            {
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
                dataGridViewIncidencias.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las incidencias: " + ex.Message);
            }
        }
        private void ReporteIncidencias_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar7_Click(object sender, EventArgs e)
        {

            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }

        private void txtDescripcionI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
