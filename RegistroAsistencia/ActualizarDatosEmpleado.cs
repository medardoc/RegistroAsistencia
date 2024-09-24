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
    public partial class ActualizarDatosEmpleado : Form
    {
        private SqlConnection connection;

        public ActualizarDatosEmpleado()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RegistroAsistenciaConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Empleados
                             SET Nombre = @Nombre,
                                 Apellido = @Apellido,
                                 Email = @Email,
                                 Telefono = @Telefono,
                                 Direccion = @Direccion,
                                 CodigoPostalID = @CodigoPostalID,
                                 DepartamentoID = @DepartamentoID,
                                 ContratoID = @ContratoID,
                                 RolID = @RolID
                             WHERE Rut = @Rut";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Rut", txtRutActualizar.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombreActualizar.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellidoActualizar.Text);
                    command.Parameters.AddWithValue("@Email", txtEmailActualizar.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefonoActualizar.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccionActualizar.Text);
                    command.Parameters.AddWithValue("@CodigoPostalID", txtCodigoPActualizar.Text);
                    command.Parameters.AddWithValue("@DepartamentoID", txtDepartamentoIDActualizar.Text);
                    command.Parameters.AddWithValue("@ContratoID", txtContratoIDActualizar.Text);
                    command.Parameters.AddWithValue("@RolID", txtRolIDActualizar.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado con el RUT proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    
        private void btnConsultarActualizable_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Empleados";
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewActualizar.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void dataGridViewActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewActualizar.Rows[e.RowIndex];

                // Rellenar los TextBox con los datos de la fila seleccionada
                txtRutActualizar.Text = row.Cells["Rut"].Value.ToString();
                txtNombreActualizar.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoActualizar.Text = row.Cells["Apellido"].Value.ToString();
                txtEmailActualizar.Text = row.Cells["Email"].Value.ToString();
                txtTelefonoActualizar.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccionActualizar.Text = row.Cells["Direccion"].Value.ToString();
                txtCodigoPActualizar.Text = row.Cells["CodigoPostalID"].Value.ToString();
                txtDepartamentoIDActualizar.Text = row.Cells["DepartamentoID"].Value.ToString();
                txtContratoIDActualizar.Text = row.Cells["ContratoID"].Value.ToString();
                txtRolIDActualizar.Text = row.Cells["RolID"].Value.ToString();
            }
        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            // Abrir la vista MenuAdministrador
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
            this.Close(); // Cierra la ventana actual
        }

        private void ActualizarDatosEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}