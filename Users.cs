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

namespace DesktopKalendula
{
    public partial class Users : Form
    {
        private MenuLateral menu;

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
            int espacio = 120;

            for (int i = 0; i < labels.Length; i++)
            {
                // Crear Label
                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Location = new Point(90, espacio);
                lbl.AutoSize = true;
                lbl.Font = Fuentes.RubikRegular(10);
                lbl.ForeColor = Color.FromArgb(92, 135, 153);
                panelformulario.Controls.Add(lbl);

                // Crear TextBox
                TextBox txt = new TextBox();
                txt.Location = new Point(90, espacio + 30);
                txt.Width = 410;
                txt.Height = 30;
                txt.Font = Fuentes.RubikRegular(15);
                txt.ForeColor= Color.FromArgb(252,250, 249);
                txt.BorderStyle = BorderStyle.None;
               

                // Si es contraseña, ocultar caracteres
                if (i == 3)
                {
                    txt.PasswordChar = '*';
                }

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
            panelformulario.Controls.Add(btnAdd);

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
    

