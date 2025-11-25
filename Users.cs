using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;

namespace DesktopKalendula
{
    public partial class Users : Form
    {
        private MenuLateral menu;
        private FlowLayoutPanel panelTarjetas;

        public Users()
        {
            InitializeComponent();
            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
            ConfigurarMenu();


            UsersLogo.Location = new Point(150, 150);
            btnadd.Location = new Point(1500, 200);
            btnadd.Font = Fuentes.RubikSemiBold(15);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            if(panelTarjetas == null)
            {
                panelTarjetas = new FlowLayoutPanel();
                panelTarjetas.Location = new Point(70,300);
                panelTarjetas.Size = new Size(800, 500);
                panelTarjetas.AutoScroll = true;
                panelTarjetas.FlowDirection = FlowDirection.LeftToRight;
                panelTarjetas.WrapContents = true;
                panelTarjetas.Padding = new Padding(10);
                this.Controls.Add(panelTarjetas);
            }

            CargarTarjetasExistentes();

            
        }
         
        private void CrearTarjetaUsuario(InfoUser usuario)

        {
            string ruta = @"Diseño\LogoUser.png";

            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(300, 200);
            tarjeta.BackColor = Color.White;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.Margin = new Padding(10);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(ruta);
            pictureBox.Location = new Point(90, 20);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            tarjeta.Controls.Add(pictureBox);

            Label lblNombre = new Label();
            lblNombre.Text = usuario.username;
            lblNombre.Font = Fuentes.RubikMedium(14);
            lblNombre.ForeColor = Color.FromArgb(92, 135, 153);
            lblNombre.Location = new Point(20, 80);
            lblNombre.AutoSize = true;
            tarjeta.Controls.Add(lblNombre);

            Label lblEmail = new Label();
            lblEmail.Text = usuario.email;
            lblEmail.Font = Fuentes.RubikRegular(10);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(20, 160);
            lblEmail.AutoSize = true;
            tarjeta.Controls.Add(lblEmail);

            Label lblRol = new Label();
            lblRol.Text = $"Role: {usuario.role}";
            lblRol.Font = Fuentes.RubikRegular(10);
            lblRol.ForeColor = Color.FromArgb(204, 163, 193);
            lblRol.Location = new Point(20, 260);
            lblRol.AutoSize = true;
            tarjeta.Controls.Add(lblRol);

            Button btnEliminar = new Button();
            btnEliminar.Text = "✕";
            btnEliminar.Size = new Size(30, 30);
            btnEliminar.Location = new Point(230, 10);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.BackColor = Color.FromArgb(229, 122, 122);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Click += (s, args) =>
            {
                panelTarjetas.Controls.Remove(tarjeta);
            };
            tarjeta.Controls.Add(btnEliminar);

            panelTarjetas.Controls.Add(tarjeta);
        }

        private void CargarTarjetasExistentes()
        {
            List<InfoUser> usuarios = UsuarioManager.LeerUsuarios();

            foreach (InfoUser usuario in usuarios) {
                CrearTarjetaUsuario(usuario);

            }



        }

        private void ConfigurarMenu()
        {
            menu = new MenuLateral(this);

            menu.ColorFondo = Color.FromArgb(211, 145, 109);
            menu.ColorTexto = Color.FromArgb(61, 23, 0);
            menu.ColorHover = Color.FromArgb(190, 125, 90);

            menu.NombreUsuario = "Tu Nombre";
            menu.CorreoUsuario = "tu@correo.com";

            menu.AgregarOpcion("🏠", "Home", () => IrAInicio());
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            Panel panelformulario = new Panel();
            panelformulario.Size = new Size(600, 700);
            panelformulario.BackColor = Color.FromArgb(228, 235, 241);
            panelformulario.Location = new Point(
                (this.ClientSize.Width - panelformulario.Width) / 2,
                (this.ClientSize.Height - panelformulario.Height) / 2
                 );


            Label lblTitulo = new Label();
            lblTitulo.Text = "Please fill in all the information";
            lblTitulo.Font = Fuentes.RubikMedium(20);
            lblTitulo.ForeColor = Color.FromArgb(92,135,153);
            lblTitulo.AutoSize = true;
            panelformulario.Controls.Add(lblTitulo);

            lblTitulo.Left = (panelformulario.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 40;

            string[] labels = { "Fist Name","Last Name", "Email", "Password", "Confirm Password"};

            TextBox[] textBoxes = new TextBox[5];
            int espacio = 120;


            for (int i = 0; i < labels.Length; i++)
            {
              
                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Location = new Point(90, espacio);
                lbl.AutoSize = true;
                lbl.Font = Fuentes.RubikRegular(10);
                lbl.ForeColor = Color.FromArgb(92, 135, 153);
                panelformulario.Controls.Add(lbl);

               
                TextBox txt = new TextBox();
                txt.Location = new Point(90, espacio + 30);
                txt.Width = 410;
                txt.Height = 40;
                txt.Font = Fuentes.RubikRegular(15);
                txt.ForeColor= Color.FromArgb(61, 23, 0);
                txt.BorderStyle = BorderStyle.None;


                // Si es contraseña, ocultar caracteres
                if (i == 3 || i ==4)
                {
                    txt.PasswordChar = '*';
                }

                textBoxes[i] = txt;

                panelformulario.Controls.Add(txt);

                espacio += 70;
            }

            ComboBox combobox = new ComboBox();


            Button btnAdd = new Button();
            btnAdd.Text = "Añadir Usuario";
            btnAdd.Location = new Point(150, espacio + 50);
            btnAdd.Width = 250;
            btnAdd.Height = 50;
            btnAdd.BackColor = Color.FromArgb(204, 163, 193);
            btnAdd.Font = Fuentes.RubikRegular(15);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(252, 250, 249);

            btnAdd.Click += (s, args) =>
            {
                String firstName = textBoxes[0].Text;
                String lastName = textBoxes[1].Text;
                String email = textBoxes[2].Text;
                String password = textBoxes[3].Text;
                String confirmPassword = textBoxes[4].Text;

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please complete all the fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = $"{firstName} {lastName}";

                InfoUser nuevoUsuario = UsuarioManager.RegistrarUsuario(fullName, password, email, "Developer");

                if (nuevoUsuario != null)
                {
                    CrearTarjetaUsuario(nuevoUsuario);
                    panelformulario.Visible = false;
                    MessageBox.Show($"User:{fullName} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("The email is already used","Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            panelformulario.Controls.Add(btnAdd);
            this.Controls.Add(panelformulario);

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(150, espacio + 120);
            btnCancelar.Width = 250;
            btnCancelar.Height = 50;
            btnCancelar.BackColor = Color.FromArgb(229, 122, 122);
            btnCancelar.Font = Fuentes.RubikRegular(15);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(252, 250, 249);

            btnCancelar.Click += (s, args) =>
            {
                panelformulario.Visible = false;
            };

            panelformulario.Controls.Add(btnCancelar);
            this.Controls.Add(panelformulario);
            panelformulario.BringToFront();
        }
    }

}
    

