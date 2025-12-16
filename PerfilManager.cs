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

            InfoUser manager = SesionActual.UsuarioActual;

            if (manager == null || manager.role.ToLower() != "manager") 
            {
                MessageBox.Show("You are trying to access the manager's profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            buttonPendientes.Location = new Point(1150,800);
            buttonPendientes.Font = Fuentes.RubikBold(15);



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
            if (SesionActual.UsuarioActual != null && SesionActual.UsuarioActual.role.ToLower() == "manager")
            {
                menu.AgregarOpcion("👥", "Users", () => IrAUsuarios());
            }
            menu.AgregarOpcion("🚪", "Log out", () => CerrarSesion());

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
            home.Show();
            this.Close();
        }

        private void IrAUsuarios()
        {
            Users users = new Users();
            users.Show();
            this.Close();
        }

        private void CerrarSesion()
        {
            DialogResult resultado = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                SesionActual.CerrarSesionYReiniciar();
            }
        }

        private void ConfigurarInterfazPerfil()
        {
            string ruta = @"Diseño\AvatarMarron.png";

            InfoUser manager = SesionActual.UsuarioActual;

            if(manager == null || manager.role.ToLower() != "manager") {
                return;
            }

            Label lblTitulo = new Label();
            lblTitulo.Text = "Manager Profile";
            lblTitulo.Font = Fuentes.Calistoga(40);
            lblTitulo.ForeColor = Color.FromArgb(211, 145, 109);
            lblTitulo.Location = new Point(300, 200);
            lblTitulo.AutoSize = true;
            this.Controls.Add(lblTitulo);

            PictureBox pbAvatar = new PictureBox();
            pbAvatar.Size = new Size(200, 200);
            pbAvatar.Location = new Point(350, 350);
            pbAvatar.SizeMode = PictureBoxSizeMode.CenterImage;
            pbAvatar.Image = Image.FromFile( ruta );
            pbAvatar.BackColor = Color.White;
            this.Controls.Add(pbAvatar);

            Button btnEditarFoto = new Button();
            btnEditarFoto.Text = "Change Photo";
            btnEditarFoto.Size = new Size(200, 40);
            btnEditarFoto.Font = Fuentes.RubikBold(15);
            btnEditarFoto.Location = new Point(350, 550);
            btnEditarFoto.BackColor = Color.FromArgb(211, 145, 109);
            btnEditarFoto.ForeColor = Color.White;
            btnEditarFoto.FlatStyle = FlatStyle.Flat;
            btnEditarFoto.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnEditarFoto);

            Panel panelInfo = new Panel();  
            panelInfo.Left = (this.ClientSize.Width - panelInfo.Width);
            panelInfo.Top = (this.ClientSize.Height - panelInfo.Height);
            panelInfo.Size = new Size(700, 400);
            panelInfo.BackColor = Color.FromArgb(224,182,159);
            panelInfo.BorderStyle = BorderStyle.None;
            this.Controls.Add(panelInfo);

            int yPos = 30;
            int spacing = 80;

            Label lblNombreTitulo = new Label();
            lblNombreTitulo.Text = "Name:";
            lblNombreTitulo.Font = Fuentes.RubikBold(15);
            lblNombreTitulo.ForeColor = Color.White;
            lblNombreTitulo.Location = new Point(30, yPos);
            lblNombreTitulo.AutoSize = true;
            panelInfo.Controls.Add(lblNombreTitulo);

            Label lblNombreValor = new Label();
            lblNombreValor.Text = manager.username;
            lblNombreValor.Font = Fuentes.RubikMedium(15);
            lblNombreValor.ForeColor = Color.White;
            lblNombreValor.Location = new Point(100, yPos);
            lblNombreValor.AutoSize = true;
            lblNombreValor.Tag = "nombre";
            panelInfo.Controls.Add(lblNombreValor);

            yPos += spacing;


            Label lblEmailTitulo = new Label();
            lblEmailTitulo.Text = "Email:";
            lblEmailTitulo.Font = Fuentes.RubikBold(15);
            lblEmailTitulo.ForeColor = Color.White;
            lblEmailTitulo.Location = new Point(30, yPos);
            lblEmailTitulo.AutoSize = true;
            panelInfo.Controls.Add(lblEmailTitulo);

            Label lblEmailValor = new Label();
            lblEmailValor.Text = manager.email;
            lblEmailValor.Font = Fuentes.RubikMedium(15);
            lblEmailValor.ForeColor = Color.White;
            lblEmailValor.Location = new Point(100, yPos);
            lblEmailValor.AutoSize = true;
            lblEmailValor.Tag = "email";
            panelInfo.Controls.Add(lblEmailValor);

            yPos += spacing;

            // Role
            Label lblRolTitulo = new Label();
            lblRolTitulo.Text = "Role:";
            lblRolTitulo.Font = Fuentes.RubikBold(15);
            lblRolTitulo.ForeColor = Color.White;
            lblRolTitulo.Location = new Point(30, yPos);
            lblRolTitulo.AutoSize = true;
            panelInfo.Controls.Add(lblRolTitulo);

            Label lblRolValor = new Label();
            lblRolValor.Text = manager.role;
            lblRolValor.Font = Fuentes.RubikMedium(15);
            lblRolValor.ForeColor = Color.White;
            lblRolValor.Location = new Point(100, yPos );
            lblRolValor.AutoSize = true;
            lblRolValor.Tag = "role";
            panelInfo.Controls.Add(lblRolValor);

            buttonEditarDatos.Location = new Point(630, 330);
            buttonEditarDatos.FlatAppearance.BorderSize = 0;
            panelInfo.Controls.Add(buttonEditarDatos);

            yPos += spacing;




        }
        private void mostrarPanelEdicion(InfoUser manager)
        {
            Panel panelEditar = new Panel();
            panelEditar.Size = new Size(600, 550);
            panelEditar.BackColor = Color.FromArgb(228, 235, 241);
            panelEditar.Location = new Point(
                (this.ClientSize.Width - panelEditar.Width) / 2,
                (this.ClientSize.Height - panelEditar.Height) / 2
            );
            panelEditar.BorderStyle = BorderStyle.FixedSingle;

            Label lblTitulo = new Label();
            lblTitulo.Text = "Edit Profile";
            lblTitulo.Font = Fuentes.RubikMedium(20);
            lblTitulo.ForeColor = Color.FromArgb(92, 135, 153);
            lblTitulo.AutoSize = true;
            panelEditar.Controls.Add(lblTitulo);
            lblTitulo.Left = (panelEditar.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 40;

            string[] labels = { "Name", "Email", "New Password (optional)" };
            TextBox[] textBoxes = new TextBox[3];
            int espacio = 120;

            for (int i = 0; i < labels.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Location = new Point(90, espacio);
                lbl.AutoSize = true;
                lbl.Font = Fuentes.RubikRegular(12);
                lbl.ForeColor = Color.FromArgb(92, 135, 153);
                panelEditar.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Location = new Point(90, espacio + 30);
                txt.Width = 410;
                txt.Height = 40;
                txt.Font = Fuentes.RubikRegular(15);
                txt.ForeColor = Color.FromArgb(61, 23, 0);
                txt.BorderStyle = BorderStyle.FixedSingle;

                switch (i)
                {
                    case 0: txt.Text = manager.username; 
                        break;
                    case 1: txt.Text = manager.email; 
                        break;
                    case 2:
                        txt.PasswordChar = '*';
                        break;
                }

                textBoxes[i] = txt;
                panelEditar.Controls.Add(txt);

                espacio += 80;
            }

            Button btnGuardar = new Button();
            btnGuardar.Text = "Save Changes";
            btnGuardar.Location = new Point(150, espacio + 30);
            btnGuardar.Width = 250;
            btnGuardar.Height = 50;
            btnGuardar.BackColor = Color.FromArgb(204, 163, 193);
            btnGuardar.Font = Fuentes.RubikRegular(15);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(252, 250, 249);
            btnGuardar.Click += (s, args) =>
            {
                string nuevoNombre = textBoxes[0].Text.Trim();
                string nuevoEmail = textBoxes[1].Text.Trim();
                string nuevaContraseña = textBoxes[2].Text.Trim();

                if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoEmail))
                {
                    MessageBox.Show("Name and Email are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nuevaContraseña == "Leave empty to keep current" || string.IsNullOrWhiteSpace(nuevaContraseña))
                {
                    nuevaContraseña = null;
                }

                if (UsuarioManager.EditarUsuario(manager.id, nuevoNombre, nuevoEmail, nuevaContraseña, manager.role))
                {
                    SesionActual.UsuarioActual.username = nuevoNombre;
                    SesionActual.UsuarioActual.email = nuevoEmail;
                    if (nuevaContraseña != null)
                        SesionActual.UsuarioActual.password = nuevaContraseña;

                    ActualizarDatosPerfil();

                    menu.ActualizarDatosUsuario(nuevoNombre, nuevoEmail);

                    panelEditar.Visible = false;
                    this.Controls.Remove(panelEditar);

                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            panelEditar.Controls.Add(btnGuardar);

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancel";
            btnCancelar.Location = new Point(150, espacio + 90);
            btnCancelar.Width = 250;
            btnCancelar.Height = 50;
            btnCancelar.BackColor = Color.FromArgb(229, 122, 122);
            btnCancelar.Font = Fuentes.RubikRegular(15);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(252, 250, 249);
            btnCancelar.Click += (s, args) =>
            {
                panelEditar.Visible = false;
                this.Controls.Remove(panelEditar);
            };
            panelEditar.Controls.Add(btnCancelar);

            this.Controls.Add(panelEditar);
            panelEditar.BringToFront();
        }

        private void ActualizarDatosPerfil()
        {
            InfoUser manager = SesionActual.UsuarioActual;

            Panel panelinfo = this.Controls.OfType<Panel>().
                FirstOrDefault(p => p.Location == new Point(600,400));

            if (panelinfo == null ) return;

            Label lblNombre = panelinfo.Controls.OfType<Label>().
                FirstOrDefault(l => l.Tag?.ToString() == "nombre");
            if (lblNombre != null)
                lblNombre.Text = manager.username;


            Label lblEmail = panelinfo.Controls.OfType<Label>().
                FirstOrDefault(l => l.Tag?.ToString() == "email");
            if (lblEmail != null)
                lblEmail.Text = manager.email;

            Label lblRol = panelinfo.Controls.OfType<Label>().
                FirstOrDefault(l => l.Tag?.ToString() == "role");
            if (lblRol != null)
                lblRol.Text = manager.role;

        }

        private void buttonPendientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to your tasks....");
        }

        private void buttonEditarDatos_Click_1(object sender, EventArgs e)
        {
            InfoUser manager = SesionActual.UsuarioActual;

            if (manager == null)
            {
                MessageBox.Show("No user information found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mostrarPanelEdicion(manager);

        }
    }
}

