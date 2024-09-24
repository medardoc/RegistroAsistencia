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
    public partial class loginAdministrativo : Form
    {
        public loginAdministrativo()
        {
            InitializeComponent();
        }

        private void loginAdministrativo_Load(object sender, EventArgs e)
        {
            // Código para inicializar la vista si es necesario
        }

        // Evento para el botón "Volver Atrás"
        private void btnAtras3_Click(object sender, EventArgs e)
        {
            // Instancia de la vista Panel
            Panel panel = new Panel();

            // Mostrar la vista Panel
            panel.Show();

            // Cerrar la vista actual (loginAdministrativo)
            this.Close();
        }

        // Evento para el botón "Iniciar Sesión"
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            string empleadoID = txtEmpleadoID.Text.Trim();
            string rut = txtEmpleadoRut.Text.Trim();

            // Verificar credenciales
            if (VerificarCredenciales(empleadoID, rut))
            {
                // Abrir el menú administrativo
                MenuAdministrador menuAdmin = new MenuAdministrador();
                menuAdmin.Show();

                // Cerrar la vista actual (loginAdministrativo)
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas o no autorizado.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarCredenciales(string empleadoID, string rut)
        {
            bool esValido = false;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Empleados
                    WHERE EmpleadoID = @EmpleadoID
                      AND Rut = @Rut
                      AND RolID = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                    command.Parameters.AddWithValue("@Rut", rut);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        esValido = (count > 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al verificar las credenciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return esValido;
        }
    }
}