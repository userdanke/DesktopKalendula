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
using DesktopKalendula.Properties;

namespace DesktopKalendula
{
    public partial class PerfilManager : Form
    {
        private MenuLateral menu;
        public PerfilManager()
        {
            InitializeComponent();
            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
            ConfigurarInterfazPerfil();
            ConfigurarMenu();
        }

        private void PerfilManager_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Image = Resources.Logo;
            pictureBoxLogo.Location = new Point(850, 950);

            buttonEditarDatos.Location = new Point(1600,900);

            buttonPendientes.Location = new Point(1600,200);



        }
        private void ConfigurarMenu()
        {
            string NombreUsuario = "Tu Nombre";
            string CorreoUsuario = "tu@correo.com";

            if (SesionActual.HaySesionActiva())
            {
                NombreUsuario = SesionActual.UsuarioActual.username;
                CorreoUsuario = SesionActual.UsuarioActual.email;
            }

            menu = new MenuLateral(this, NombreUsuario, CorreoUsuario);

            menu.ColorFondo = Color.FromArgb(211, 145, 109);
            menu.ColorTexto = Color.FromArgb(61, 23, 0);
            menu.ColorHover = Color.FromArgb(190, 125, 90);

            menu.AgregarOpcion("🏠", "Home", () => IrAInicio());
            menu.AgregarOpcion("👥", "Usuarios", () => IrAUsuarios());
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
            Home home = new Home();
            home.ShowDialog();
        }

        private void IrAUsuarios()
        {
            Users users = new Users();
            users.ShowDialog();
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

        private void ConfigurarInterfazPerfil()
        {
            string ruta = @"Diseño\LogoUser.png";

            Label lblTitulo = new Label();
            lblTitulo.Text = "Manager Profile";
            lblTitulo.Font = Fuentes.Calistoga(40);
            lblTitulo.ForeColor = Color.FromArgb(61, 23, 0);
            lblTitulo.Location = new Point(80, 80);
            lblTitulo.AutoSize = true;
            this.Controls.Add(lblTitulo);

            PictureBox pbAvatar = new PictureBox();
            pbAvatar.Size = new Size(200, 200);
            pbAvatar.Location = new Point(150, 200);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.Image = Image.FromFile( ruta );
            pbAvatar.BackColor = Color.White;
            this.Controls.Add(pbAvatar);

            Button btnEditarFoto = new Button();
            btnEditarFoto.Text = "Change Photo";
            btnEditarFoto.Size = new Size(200, 40);
            btnEditarFoto.Location = new Point(150, 450);
            btnEditarFoto.BackColor = Color.FromArgb(211, 145, 109);
            btnEditarFoto.ForeColor = Color.White;
            btnEditarFoto.FlatStyle = FlatStyle.Flat;
            btnEditarFoto.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnEditarFoto);
 
        }

    }
}

