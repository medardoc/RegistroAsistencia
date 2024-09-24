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
    public partial class AgregarColaborador : Form
    {
        // Definir connectionString como una variable de instancia
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;

        public AgregarColaborador()
        {
            InitializeComponent();
        }

        private void AgregarColaborador_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar cualquier dato inicial si es necesario
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener datos de los campos de texto
            string nombre = txtNombreAgregar.Text;
            string apellido = txtApellidoAgregar.Text;
            string rut = textRutAgregar.Text;
            string email = txtEmailAgregar.Text;
            string telefono = txtTelefonoAgregar.Text;
            string direccion = txtDireccionAgregar.Text;
            string codigoPostalID = txtCodigoPAgregar.Text;
            string departamentoID = txtDepartamentoIDAgregar.Text;
            string contratoID = txtContratoIDAgregar.Text;
            string rolID = txtRolIDAgregar.Text;

            // Consulta SQL para insertar datos
            string query = "INSERT INTO Empleados (Nombre, Apellido, Rut, Email, Telefono, Direccion, CodigoPostalID, DepartamentoID, ContratoID, RolID) " +
                           "VALUES (@Nombre, @Apellido, @Rut, @Email, @Telefono, @Direccion, @CodigoPostalID, @DepartamentoID, @ContratoID, @RolID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Rut", rut);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@CodigoPostalID", codigoPostalID);
                    command.Parameters.AddWithValue("@DepartamentoID", departamentoID);
                    command.Parameters.AddWithValue("@ContratoID", contratoID);
                    command.Parameters.AddWithValue("@RolID", rolID);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Verificar si el comando se ejecutó correctamente
                    if (result > 0)
                    {
                        MessageBox.Show("Empleado agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el empleado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void btnRegresar3_Click(object sender, EventArgs e)
        {
            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }

        public void btnRevisar_Click(object sender, EventArgs e)
        {
            // Cargar datos de la tabla Empleados en el DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Empleados"; // Ajusta la consulta según tu tabla
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewAgregar.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
    }
}