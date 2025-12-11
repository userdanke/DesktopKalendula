using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopKalendula.Diseño
{
    public class MenuLateral
    {
        private Panel panelMenu;
        private Panel fondo;
        private Timer timerMenu;
        private Form formularioPadre;
        private bool menuAbierto = false;

        private const int ANCHO_MENU = 300;
        private const int VELOCIDAD = 70;

        public Color ColorFondo { get; set; } = Color.FromArgb(228, 235, 241);
        public Color ColorTexto { get; set; } = Color.FromArgb(61, 23, 0);
        public Color ColorHover { get; set; } = Color.FromArgb(168, 184, 197);

        public string NombreUsuario { get; set; } = "Usuario";
        public string CorreoUsuario { get; set; } = "correo@ejemplo.com";
        public Image FotoUsuario { get; set; } = null;


        public MenuLateral(Form formulario, string nombreUsuario, string correoUsuario)
        {

            formularioPadre = formulario;
            NombreUsuario = nombreUsuario;
            CorreoUsuario = correoUsuario;
            InicializarMenu();
        }


        private void InicializarMenu()
        {
            fondo = new Panel();
            fondo.BackColor = Color.FromArgb(252, 250, 249);
            fondo.Size = formularioPadre.ClientSize;
            fondo.Location = new Point(0, 0);
            fondo.Visible = false;
            fondo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fondo.Click += (s, e) => Cerrar();
            formularioPadre.Controls.Add(fondo);


            panelMenu = new Panel();
            panelMenu.Width = ANCHO_MENU;
            panelMenu.Height = formularioPadre.Height;
            panelMenu.BackColor = ColorFondo;
            panelMenu.Location = new Point(-ANCHO_MENU, 0);
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            formularioPadre.Controls.Add(panelMenu);


            Button btnCerrar = new Button();
            btnCerrar.Text = "✕";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.Location = new Point(ANCHO_MENU - 50, 10);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Font = Fuentes.RubikRegular(15);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Click += (s, e) => Toggle();
            panelMenu.Controls.Add(btnCerrar);


            PictureBox fotoPerfil = new PictureBox();
            fotoPerfil.Size = new Size(60, 60);
            fotoPerfil.Location = new Point(20, 70);
            fotoPerfil.BackColor = Color.FromArgb(168,184,197);
            fotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoPerfil.Click += (s, e) =>
            {

                PerfilManager perfil = new PerfilManager();
                perfil.ShowDialog();

            };


            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, fotoPerfil.Width, fotoPerfil.Height);
            fotoPerfil.Region = new Region(path);

            if (FotoUsuario != null)
                fotoPerfil.Image = FotoUsuario;

            panelMenu.Controls.Add(fotoPerfil);


            Label lblNombre = new Label();
            lblNombre.Text = NombreUsuario;
            lblNombre.Font = Fuentes.RubikBold(12);
            lblNombre.ForeColor = ColorTexto;
            lblNombre.Location = new Point(90, 75);
            lblNombre.AutoSize = true;
            panelMenu.Controls.Add(lblNombre);

            Label lblCorreo = new Label();
            lblCorreo.Text = CorreoUsuario;
            lblCorreo.Font = Fuentes.RubikRegular(10);
            lblCorreo.ForeColor = ColorTexto;
            lblCorreo.Location = new Point(90, 100);
            lblCorreo.AutoSize = true;
            panelMenu.Controls.Add(lblCorreo);



            timerMenu = new Timer();
            timerMenu.Interval = 10;
            timerMenu.Tick += TimerMenu_Tick;
        }

        public void AgregarOpcion(string icono, string texto, Action accion)
        {
            int posicionY = 250 + (panelMenu.Controls.Count - 6) * 50;

            Panel itemMenu = new Panel();
            itemMenu.Width = ANCHO_MENU - 20;
            itemMenu.Height = 45;
            itemMenu.Location = new Point(40, posicionY);
            itemMenu.BackColor = Color.Transparent;
            itemMenu.Tag = "item";

            EventHandler clickHandler = (s, e) =>
            {
                accion?.Invoke();
                Cerrar();
            };

            itemMenu.MouseEnter += (s, e) => itemMenu.BackColor = Color.FromArgb(168, 184, 197);
            itemMenu.MouseLeave += (s, e) => itemMenu.BackColor = Color.Transparent;
            itemMenu.Click += clickHandler;


            Label lblIcono = new Label();
            lblIcono.Text = icono;
            lblIcono.Font = new Font("Segoe UI", 16);
            lblIcono.Location = new Point(0, 8);
            lblIcono.AutoSize = true;
            lblIcono.BackColor = Color.Transparent;
            lblIcono.Click += clickHandler; 
            itemMenu.Controls.Add(lblIcono);


            Label lblTexto = new Label();
            lblTexto.Text = texto;
            lblTexto.Font = Fuentes.RubikRegular(15);
            lblTexto.ForeColor = ColorTexto;
            lblTexto.Location = new Point(55, 12);
            lblTexto.AutoSize = true;
            lblTexto.BackColor = Color.Transparent;
            lblTexto.Click += clickHandler; 
            itemMenu.Controls.Add(lblTexto);

            panelMenu.Controls.Add(itemMenu);
        }


        private void TimerMenu_Tick(object sender, EventArgs e)
        {
            if (menuAbierto) 
            {
                if (panelMenu.Left < 0)
                {
                    panelMenu.Left += VELOCIDAD;
                    if (panelMenu.Left > 0)
                        panelMenu.Left = 0;
                }
                else
                {
                    timerMenu.Stop();
                }
            }
            else 
            {
                if (panelMenu.Left > -ANCHO_MENU)
                {
                    panelMenu.Left -= VELOCIDAD;
                    if (panelMenu.Left < -ANCHO_MENU)
                        panelMenu.Left = -ANCHO_MENU;
                }
                else
                {
                    timerMenu.Stop();
                    fondo.Visible = false;
                }
            }
        }


        public void Toggle()
        {
            menuAbierto = !menuAbierto;

            if (menuAbierto)
            {
                fondo.Visible = true;
                fondo.BringToFront();
                panelMenu.BringToFront();
            }

            timerMenu.Start();
        }

        public void Abrir()
        {
            if (!menuAbierto)
                Toggle();
        }

        public void Cerrar()
        {
            if (menuAbierto)
                Toggle();
        }

        public bool EstaAbierto()
        {
            return menuAbierto;
        }
    }
}
