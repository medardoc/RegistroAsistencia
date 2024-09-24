using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RegistroAsistencia
{
    public partial class MarcarEntrada : Form
    {
        public readonly string _connectionString;
        public MarcarEntrada()
        {
            InitializeComponent();
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MarcarEntrada_Load(object sender, EventArgs e)
        {

        }

        // Evento para el botón "Volver Atrás"
        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Instancia de la vista Panel
            Panel panel = new Panel();

            // Mostrar la vista Panel
            panel.Show();

            // Cerrar la vista actual (MarcarEntrada)
            this.Close();
        }

        // Evento para el botón "Confirmar Entrada"
        private void btnConfirmarEntrada_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEntrada.Text.Trim();
            string rut = txtRutEntrada.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(rut))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Verificar si el empleado existe
                string queryEmpleado = "SELECT EmpleadoID FROM Empleados WHERE Nombre = @Nombre AND RUT = @RUT";
                SqlCommand cmdEmpleado = new SqlCommand(queryEmpleado, connection);
                cmdEmpleado.Parameters.AddWithValue("@Nombre", nombre);
                cmdEmpleado.Parameters.AddWithValue("@RUT", rut);

                object empleadoID = cmdEmpleado.ExecuteScalar();

                if (empleadoID == null)
                {
                    MessageBox.Show("El trabajador no existe.");
                    return;
                }

                // Insertar la entrada en la tabla RegistroAsistencia
                string queryInsert = "INSERT INTO RegistroAsistencia (EmpleadoID, Fecha, HoraEntrada) VALUES (@EmpleadoID, @Fecha, @HoraEntrada)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, connection);
                cmdInsert.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmdInsert.Parameters.AddWithValue("@Fecha", DateTime.Today);
                cmdInsert.Parameters.AddWithValue("@HoraEntrada", DateTime.Now.TimeOfDay);

                try
                {
                    int rowsAffected = cmdInsert.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Entrada registrada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar la entrada.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al registrar la entrada: " + ex.Message);
                }
            }
        }
    }
}
