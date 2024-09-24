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
    public partial class RegistroAsistencia : Form
    {
        private SqlConnection connection;
        public RegistroAsistencia()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            // Cambia esta cadena de conexión por la correcta para tu base de datos
            string connectionString = ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        private void btnAgregarAsistencia_Click(object sender, EventArgs e)
        {
            // Obtener datos de los TextBox
            int empleadoID;
            DateTime fecha;
            TimeSpan horaEntrada;
            TimeSpan? horaSalida = null; // Puede ser null si no se proporciona

            if (int.TryParse(txtEmpleadoIDAsistencia.Text, out empleadoID) &&
                DateTime.TryParse(txtFechaAsistencia.Text, out fecha) &&
                TimeSpan.TryParse(txtHoraEntradaA.Text, out horaEntrada))
            {
                if (!string.IsNullOrEmpty(txtHoraSalidaA.Text) && TimeSpan.TryParse(txtHoraSalidaA.Text, out TimeSpan salida))
                {
                    horaSalida = salida;
                }

                // Consulta SQL para insertar un nuevo registro de asistencia
                string query = @"INSERT INTO RegistroAsistencia (EmpleadoID, Fecha, HoraEntrada, HoraSalida)
                                 VALUES (@EmpleadoID, @Fecha, @HoraEntrada, @HoraSalida)";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.Parameters.AddWithValue("@HoraEntrada", horaEntrada);
                        command.Parameters.AddWithValue("@HoraSalida", (object)horaSalida ?? DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el registro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, verifica los datos ingresados.");
            }
        }
        private void btnMostrarAsistencia_Click(object sender, EventArgs e)
        {
            // Consulta SQL para obtener todos los registros de asistencia
            string query = "SELECT * FROM RegistroAsistencia";

            try
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewAsistencia.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tctFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar6_Click(object sender, EventArgs e)
        {

            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }

        private void RegistroAsistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
