using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopKalendula
{
    public partial class ProjectHome : Form
    {
        private MenuLateral menu;
        private Project currentProject;
        private Panel panelTablero;
        private Panel panelPendiente;
        private Panel panelEnProgreso;
        private Panel panelCompletada;

        public ProjectHome(Project project)
        {
            InitializeComponent();

            currentProject = project;

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

            ConfigurarMenu();
            InicializarTablero();

        }

        private void OpenProject_Load(object sender, EventArgs e)
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
                this.Close();
            }
        }

        private void InicializarTablero()
        {
            panelTablero = new Panel();
            panelTablero.Size = new Size(1200, 600);
            panelTablero.Location = new Point(this.ClientSize.Width / 2, 400);
            panelTablero.AutoScroll = true;
            panelTablero.BackColor = Color.FromArgb(240, 240, 240);
            this.Controls.Add(panelTablero);
            
            int anchoColumna = panelTablero.Width / 3;

            panelPendiente = new Panel();
            panelPendiente.BackColor = Color.LightGray;
            panelPendiente.Size = new Size(anchoColumna - 10, panelTablero.Height);
            panelPendiente.Location = new Point(0, 0);
            panelPendiente.AllowDrop = true;
            panelTablero.Controls.Add(panelPendiente);

            // Panel En Progreso
            panelEnProgreso = new Panel();
            panelEnProgreso.BackColor = Color.LightYellow;
            panelEnProgreso.Size = new Size(anchoColumna - 10, panelTablero.Height);
            panelEnProgreso.Location = new Point(anchoColumna, 0);
            panelEnProgreso.AllowDrop = true;
            panelTablero.Controls.Add(panelEnProgreso);

            // Panel Completada
            panelCompletada = new Panel();
            panelCompletada.BackColor = Color.LightGreen;
            panelCompletada.Size = new Size(anchoColumna - 10, panelTablero.Height);
            panelCompletada.Location = new Point(2 * anchoColumna, 0);
            panelCompletada.AllowDrop = true;
            panelTablero.Controls.Add(panelCompletada);

            ConfigurarDragDrop();

            foreach (var tarea in currentProject.tasks)
            {
                CrearTarjetaTarea(tarea);
            }
        }

        private void CrearTarjetaTarea(Task tarea)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 100);
            tarjeta.BackColor = Color.LightBlue;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.Tag = tarea;

            Label lblNombre = new Label();
            lblNombre.Text = tarea.name;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Rubik", 10, FontStyle.Bold);

            tarjeta.Controls.Add(lblNombre);

            tarjeta.Controls.Add(lblNombre);

            tarjeta.MouseDown += (s, e) =>
            {
                tarjeta.DoDragDrop(tarjeta, DragDropEffects.Move);
            };

            switch (tarea.state)
            {
                case "Pendiente":
                    panelPendiente.Controls.Add(tarjeta);
                    break;
                case "En Progreso":
                    panelEnProgreso.Controls.Add(tarjeta);
                    break;
                case "Completada":
                    panelCompletada.Controls.Add(tarjeta);
                    break;
            }
        }

        private void ConfigurarDragDrop()
        {
            Panel[] columnas = { panelPendiente, panelEnProgreso, panelCompletada };

            foreach (var col in columnas)
            {
                col.DragEnter += (s, e) => e.Effect = DragDropEffects.Move;

                col.DragDrop += (s, e) =>
                {
                    Panel tarjeta = (Panel)e.Data.GetData(typeof(Panel));
                    Panel destino = (Panel)s;

                    Task tarea = (Task)tarjeta.Tag;

                    // Actualizar estado
                    if (destino == panelPendiente) tarea.state = "Pendiente";
                    else if (destino == panelEnProgreso) tarea.state = "En Progreso";
                    else if (destino == panelCompletada) tarea.state = "Completada";

                    // Mover tarjeta al nuevo panel
                    tarjeta.Parent.Controls.Remove(tarjeta);
                    destino.Controls.Add(tarjeta);

                    // Guardar cambios en JSON
                    GuardarProyecto(currentProject);
                };
            }
        }



        public void GuardarProyecto(Project proyectoActual)
        {
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Json", "Proyectos.json");

            List<Project> proyectos = new List<Project>();

            if (File.Exists(rutaJson))
            {
                string contenido = File.ReadAllText(rutaJson);
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    proyectos = JsonConvert.DeserializeObject<List<Project>>(contenido);

                    // Reemplazamos el proyecto actual en la lista
                    proyectos = proyectos.Select(p => p.id == proyectoActual.id ? proyectoActual : p).ToList();
                }
            }
            else
            {
                // Si el JSON no existía, agregamos el proyecto actual
                proyectos.Add(proyectoActual);
            }

            string nuevoJson = JsonConvert.SerializeObject(proyectos, Formatting.Indented);
            File.WriteAllText(rutaJson, nuevoJson);
        }

        private void buttonCrearTarea_Click(object sender, EventArgs e)
        {
            CreateTask form = new CreateTask(currentProject.users);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Task nuevaTarea = form.TareaCreada;
                currentProject.tasks.Add(nuevaTarea);

                GuardarProyecto(currentProject);
                CrearTarjetaTarea(nuevaTarea);
            }
        }
    }
}
