using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopKalendula
{
    public partial class Home : Form
    {
        private MenuLateral menu;

        public Home()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

            ConfigurarMenu();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Logo.Location = new Point(865, 60);
            Logo.Size = new Size(250, 85);

            panelPrincipalMenu.Location = new Point(250, 150);
            panelPrincipalMenu.Size = new Size(1000, 800);

            labelHome.Font = Fuentes.Calistoga(35);
            labelHome.Location = new Point(85, 20);
            labelHome.ForeColor = Color.FromArgb(61, 23, 0);

            buttonNewProject.Font = Fuentes.RubikRegular(15);
            buttonNewProject.ForeColor = Color.FromArgb(255, 251, 249);
            buttonNewProject.Location = new Point(100, 100);
            buttonNewProject.Size = new Size(250, 40);

            buttonOpenProject.Font = Fuentes.RubikRegular(15);
            buttonOpenProject.ForeColor = Color.FromArgb(255, 251, 249);
            buttonOpenProject.Location = new Point(370, 100);
            buttonOpenProject.Size = new Size(250, 40);

            buttonTask.Font = Fuentes.RubikRegular(15);
            buttonTask.ForeColor = Color.FromArgb(255, 251, 249);
            buttonTask.Location = new Point(640, 100);
            buttonTask.Size = new Size(250, 40);

            panelSecundario.Location = new Point(1320, 150);
            panelSecundario.Size = new Size(500, 800);

            labelCalendar.Font = Fuentes.Calistoga(35);
            labelCalendar.Location = new Point(150, 20);
            labelCalendar.ForeColor = Color.FromArgb(61, 23, 0);

            monthCalendar1.Location = new Point(170, 100);
            monthCalendar1.Size = new Size(300, 300);
            monthCalendar1.BackColor = Color.FromArgb(252, 250, 249);


        }

        private void ConfigurarMenu()
        {
            menu = new MenuLateral(this);

            menu.ColorFondo = Color.FromArgb(211, 145, 109);
            menu.ColorTexto = Color.FromArgb(61, 23, 0);
            menu.ColorHover = Color.FromArgb(190, 125, 90);

            menu.NombreUsuario = "Tu Nombre";
            menu.CorreoUsuario = "tu@correo.com";

            menu.AgregarOpcion("🏠", "Perfil", () => IrAInicio());
            menu.AgregarOpcion("👥", "Usuarios", () => IrAUsuarios());
            menu.AgregarOpcion("⚙️", "Configuración", () => IrAConfiguracion());
            menu.AgregarOpcion("🚪", "Cerrar Sesión", () => CerrarSesion());

            btnMenu.Text = "☰";
            btnMenu.Size = new Size(50, 1200);
            btnMenu.Location = new Point(0, 40);
            btnMenu.Font = Fuentes.RubikBold(40);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.FromArgb(228, 235, 241);
            btnMenu.ForeColor = Color.FromArgb(252, 250, 249);
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Click += (s, e) => menu.Toggle();
            this.Controls.Add(btnMenu);
            btnMenu.BringToFront();
        }

        private void IrAInicio()
        {
            MessageBox.Show("Navegando a Inicio");
        }

        private void IrAReportes()
        {
            MessageBox.Show("Navegando a Reportes");
        }

        private void IrAUsuarios()
        {
            MessageBox.Show("Navegando a Usuarios");
        }

        private void IrAConfiguracion()
        {
            MessageBox.Show("Abriendo Configuración");
        }

        private void CerrarSesion()
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
