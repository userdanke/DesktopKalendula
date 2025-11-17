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
    public partial class Calendar : Form

    {

        private MenuLateral menu;
        DateTime fechaActual;
        private List<Tarea> tareas;

        public Calendar()
        {
            InitializeComponent();
            fechaActual = DateTime.Now;
            tareas = new List<Tarea>();

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

            ConfigurarMenu();

            ConfigurarGrid();
            MostrarMes();
        }

        private void Calendar_Load(object sender, EventArgs e)
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

            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.DefaultCellStyle.Font = Fuentes.RubikRegular(10);
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 163, 193);

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Dom", "Dom");
            dataGridView1.Columns.Add("Lun", "Lun");
            dataGridView1.Columns.Add("Mar", "Mar");
            dataGridView1.Columns.Add("Mie", "Mié");
            dataGridView1.Columns.Add("Jue", "Jue");
            dataGridView1.Columns.Add("Vie", "Vie");
            dataGridView1.Columns.Add("Sab", "Sáb");

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
                dataGridView1.Rows[fila].Height = 80;

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

        private void buttonAnterior_Click_1(object sender, EventArgs e)
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            
            var valor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (valor != null && valor.ToString() != "")
                return;

            int dia = Convert.ToInt32(valor);
            DateTime fechaCelda = new DateTime(fechaActual.Year, fechaActual.Month, dia);

            List<Tarea> tareasDelDia = tareas.Where(t => t.estaActivaEn(fechaCelda)).ToList();
            
            if(tareasDelDia.Count > 0)
            {
                foreach(var tarea in tareasDelDia.Take(4))
                {
                    string nombreCorto = tarea.Nombre.Length > 8 ? tarea.Nombre.Substring(0, 8) + "..." : tarea.Nombre;
                }
            }
            else
            {
                MessageBox.Show("No hay tareas para " + fechaCelda.ToShortDateString());
            }
        }
    }
}
