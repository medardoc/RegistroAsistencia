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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Carga inicial, si necesitas agregar algo al cargar el formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Si deseas agregar alguna funcionalidad para el label, puedes hacerlo aquí
        }

        // Evento para el botón Login Administrativo
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Abrir la ventana de Login Administrativo
            loginAdministrativo login = new loginAdministrativo();
            login.Show();
            this.Hide(); // Esconde el formulario actual
        }

        // Evento para el botón Marcar Salida
        private void btnSalida_Click(object sender, EventArgs e)
        {
            // Abrir la ventana de Marcar Salida
            MarcarSalida marcarSalida = new MarcarSalida();
            marcarSalida.Show();
            this.Hide(); // Esconde el formulario actual
        }

        // Evento para el botón Marcar Entrada
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            // Abrir la ventana de Marcar Entrada
            MarcarEntrada marcarEntrada = new MarcarEntrada();
            marcarEntrada.Show();
            this.Hide(); // Esconde el formulario actual
        }
    }
}
