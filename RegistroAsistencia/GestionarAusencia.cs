using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace RegistroAsistencia
{
    public partial class GestionarAusencia : Form
    {
        public GestionarAusencia()
        {
            InitializeComponent();
        }

        private void GestionarAusencia_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos iniciales si es necesario
        }

        public void btnRegresar5_Click(object sender, EventArgs e)
        {
            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }

        private void btnAgregarausencia_Click(object sender, EventArgs e)
        {
            // Obtener datos de los campos de texto
            int empleadoID = int.Parse(txtEmpleadoIDAusencia.Text);
            string tipoAusencia = comboTipoAusencia.SelectedItem.ToString();
            DateTime fechaInicio = DateTime.Parse(tctFechaInicio.Text);
            DateTime fechaFin = DateTime.Parse(txtFechaFin.Text);
            string motivo = txtTelefonoConsultar.Text;

            // Cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

            // Consulta SQL para insertar datos
            string query = "INSERT INTO GestionRazonAusencias (EmpleadoID, TipoAusencia, FechaInicio, FechaFin, Motivo) " +
                           "VALUES (@EmpleadoID, @TipoAusencia, @FechaInicio, @FechaFin, @Motivo)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                    command.Parameters.AddWithValue("@TipoAusencia", tipoAusencia);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Motivo", motivo);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Verificar si el comando se ejecutó correctamente
                    if (result > 0)
                    {
                        MessageBox.Show("Ausencia agregada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la ausencia.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnMostrarR_Click(object sender, EventArgs e)
        {
            // Cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

            // Consulta SQL para obtener los datos
            string query = "SELECT * FROM GestionRazonAusencias"; // Ajusta la consulta según tu tabla

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewAusencia.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
    }
}