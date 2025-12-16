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
    public partial class Home : Form
    {
        private MenuLateral menu;
        DateTime fechaActual = DateTime.Now;

        public Home()
        {
            InitializeComponent();
            ConfigurarMenu();

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);


            ConfigurarGrid();
            MostrarMes();

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

            InfoUser usuario = SesionActual.UsuarioActual;

            if(usuario != null && usuario.role.ToLower() != "manager")
            {
                buttonNewProject.Visible = false;
                buttonOpenProject.Location = new Point(100, 100);
            }


            panelSecundario.Location = new Point(1320, 150);
            panelSecundario.Size = new Size(500, 800);

            labelCalendar.Font = Fuentes.Calistoga(35);
            labelCalendar.Location = new Point(150, 20);
            labelCalendar.ForeColor = Color.FromArgb(61, 23, 0);

            labelMessages.Font = Fuentes.Calistoga(25);
            labelMessages.Location = new Point(155, 470);
            labelMessages.ForeColor = Color.FromArgb(61, 23, 0);


        }

        private void ConfigurarMenu()
        {
            string nombre = "Your Name";
            string correo = "your@email.com";

            if (SesionActual.HaySesionActiva())
            {
                nombre = SesionActual.UsuarioActual.username;
                correo = SesionActual.UsuarioActual.email;
            }

            menu = new MenuLateral(this, nombre, correo);

            menu.ColorFondo = Color.FromArgb(211, 145, 109);
            menu.ColorTexto = Color.FromArgb(61, 23, 0);
            menu.ColorHover = Color.FromArgb(190, 125, 90);

            if (SesionActual.HaySesionActiva())
            {
                menu.NombreUsuario = SesionActual.UsuarioActual.username;
                menu.CorreoUsuario = SesionActual.UsuarioActual.email;
            } else
            {
                menu.NombreUsuario = "Your Name";
                menu.CorreoUsuario = "your@email.com";
            }

            menu.AgregarOpcion("🏠", "Home", () => IrAInicio());

            if(SesionActual.UsuarioActual != null && SesionActual.UsuarioActual.role.ToLower() == "manager")
            {
                menu.AgregarOpcion("👥", "Usuarios", () => IrAUsuarios());
            }
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
            Home formHome = new Home();
            formHome.Show();
        }


        private void IrAUsuarios()
        {
            Users formUsuarios = new Users();
            formUsuarios.Show();
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
                SesionActual.CerrarSesionYReiniciar();
            }
        }

        private void ConfigurarGrid()
        {
            dataGridView1.Width = 354;
            dataGridView1.Height = 325;

            lblMesAnio.Font = Fuentes.RubikBold(15);
            lblMesAnio.ForeColor = Color.FromArgb(125, 85, 114);
            lblMesAnio.Location = new Point(175, 100);

            buttonAnterior.Font = Fuentes.RubikBold(12);
            buttonAnterior.BackColor = Color.FromArgb(125, 85, 114);
            buttonAnterior.ForeColor = Color.FromArgb(252, 250, 249);
            buttonAnterior.Location = new Point(130, 95);

            buttonSiguiente.Font = Fuentes.RubikBold(12);
            buttonSiguiente.BackColor = Color.FromArgb(125, 85, 114);
            buttonSiguiente.ForeColor = Color.FromArgb(252, 250, 249);
            buttonSiguiente.Location = new Point(350, 95);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Location = new Point(90, 150);

            dataGridView1.ColumnHeadersHeight = 10;

            dataGridView1.EnableHeadersVisualStyles = false; 
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 163, 193);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 250, 249);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = Fuentes.RubikRegular(10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = Fuentes.RubikRegular(10);

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 163, 193);

            dataGridView1.Columns.Add("Sun", "Sun");
            dataGridView1.Columns.Add("Mon", "Mon");
            dataGridView1.Columns.Add("Tue", "Tue");
            dataGridView1.Columns.Add("Wed", "Wed");
            dataGridView1.Columns.Add("Thu", "Thu");
            dataGridView1.Columns.Add("Fri", "Fri");
            dataGridView1.Columns.Add("Sat", "Sat");

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 50;
            }
        }

        private void MostrarMes()
        {
            dataGridView1.Rows.Clear();

            lblMesAnio.Text = fechaActual.ToString("MMMM yyyy");

            DateTime primerDia = new DateTime(fechaActual.Year, fechaActual.Month, 1);

            int diaSemana = (int)primerDia.DayOfWeek;

            int diasDelMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);

            int diaActual = 1;

            for (int fila = 0; fila < 6; fila++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[fila].Height = 50;

                for (int columna = 0; columna < 7; columna++)
                {
                    int posicion = (fila * 7) + columna;

                    if (posicion >= diaSemana && diaActual <= diasDelMes)
                    {

                        dataGridView1.Rows[fila].Cells[columna].Value = diaActual;

                        DateTime estaFecha = new DateTime(fechaActual.Year, fechaActual.Month, diaActual);
                        if (estaFecha.Date == DateTime.Now.Date)
                        {
                            dataGridView1.Rows[fila].Cells[columna].Style.BackColor = Color.FromArgb(125, 85, 114);
                            dataGridView1.Rows[fila].Cells[columna].Style.ForeColor = Color.FromArgb(252, 250, 249);
                        }

                        diaActual++;
                    }
                    else
                    {

                        dataGridView1.Rows[fila].Cells[columna].Value = "";
                    }
                }
            }

        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(-1);
            MostrarMes();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(1);
            MostrarMes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var valor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (valor != null && valor.ToString() != "")
                {
                    int dia = Convert.ToInt32(valor);
                    DateTime fechaSeleccionada = new DateTime(fechaActual.Year, fechaActual.Month, dia);

                    MessageBox.Show("You have selected : " + fechaSeleccionada.ToShortDateString());
                }
            }
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            CreateProject crearProyecto = new CreateProject();
            crearProyecto.ShowDialog();
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            OpenProject abrirProyecto = new OpenProject();
            abrirProyecto.ShowDialog();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
        }
    }
}
