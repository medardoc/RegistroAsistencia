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
    public partial class MarcarSalida : Form
    {
        private string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

        public MarcarSalida()
        {
            InitializeComponent();
        }

        private void MarcarSalida_Load(object sender, EventArgs e)
        {
            // Inicialización si es necesaria
        }

        // Evento para el botón "Volver Atrás"
        private void btnAtras2_Click(object sender, EventArgs e)
        {
            // Instancia de la vista Panel
            Panel panel = new Panel();

            // Mostrar la vista Panel
            panel.Show();

            // Cerrar la vista actual (MarcarSalida)
            this.Close();
        }

        // Evento para el botón "Confirmar salida"
        private void btnConfirmarSalida_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreSalida.Text.Trim();
            string rut = txtRutSalida.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(rut))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar si el empleado existe
                    string query = "SELECT EmpleadoID FROM Empleados WHERE Nombre = @Nombre AND Rut = @Rut";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Rut", rut);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int empleadoID = Convert.ToInt32(result);

                        // Registrar la salida
                        string insertQuery = "UPDATE RegistroAsistencia SET HoraSalida = @HoraSalida WHERE EmpleadoID = @EmpleadoID AND Fecha = CAST(GETDATE() AS DATE)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@HoraSalida", DateTime.Now.TimeOfDay);
                        insertCommand.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Salida registrada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la salida. Verifique los datos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El trabajador no existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }
    }
}
