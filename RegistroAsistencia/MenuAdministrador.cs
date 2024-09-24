using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistencia
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // Puedes inicializar cualquier componente aquí si es necesario
        }

        private void btnIrConsultar_Click(object sender, EventArgs e)
        {
            // Abrir la vista ConsultarEmpleado
            ConsultarEmpleado consultarEmpleado = new ConsultarEmpleado();
            consultarEmpleado.Show();
            this.Close(); // Opcional: Cierra la ventana actual si no deseas mantenerla abierta
        }

        private void btnVamoActualizar_Click(Object sender, EventArgs e)
        {
            //Abrir la vista ActualizarDatosEmpleado
            ActualizarDatosEmpleado actualizarDatosEmpleado = new ActualizarDatosEmpleado();
            actualizarDatosEmpleado.Show();
            this.Close();
        }

        private void btnIrEliminar_Click(object sender, EventArgs e)
        {
            // Abrir la vista EliminarEmpleado
            EliminarEmpleado eliminarEmpleado = new EliminarEmpleado();
            eliminarEmpleado.Show();
            this.Close(); // Opcional
        }

        private void btnIrAgregar_Click(object sender, EventArgs e)
        {
            // Abrir la vista AgregarColaborador
            AgregarColaborador agregarColaborador = new AgregarColaborador();
            agregarColaborador.Show();
            this.Close(); // Opcional
        }

        private void btnIrAusencias_Click(object sender, EventArgs e)
        {
            // Abrir la vista GestionarAusencia
            GestionarAusencia gestionarAusencia = new GestionarAusencia();
            gestionarAusencia.Show();
            this.Close(); // Opcional
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Abrir la vista Panel
            Panel panel = new Panel();
            panel.Show();
            this.Close(); // Cierra la ventana actual
        }
        private void btnRegistroAsistencia_Click(object sender, EventArgs e)
        {
            // Abrir la Vista RegistroAsistencia
            RegistroAsistencia registroAsistencia = new RegistroAsistencia();
            registroAsistencia.Show();
            this.Close();
        }
        private void btnReporteIncidencia_Click(object sender, EventArgs e)
        {
            //Abrir la vista ReporteIncidencias 
            ReporteIncidencias reporteIncidencias = new ReporteIncidencias();   
            reporteIncidencias.Show();  
            this.Close();
        }
    }
}