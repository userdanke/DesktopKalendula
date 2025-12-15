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

namespace DesktopKalendula
{
    public partial class ProjectHome : Form
    {
        private MenuLateral menu;
        private Project currentProject;
        private Panel panelTablero;
        private FlowLayoutPanel colPendiente;
        private FlowLayoutPanel colEnProgreso;
        private FlowLayoutPanel colCompletada;

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
            panelTablero = new Panel
            {
                Size = new Size(1200, 600),
                Location = new Point(this.ClientSize.Width / 2, 400),
                BackColor = Color.FromArgb(240, 240, 240),
                AutoScroll = true
            };

            this.Controls.Add(panelTablero);

            int anchoColumna = panelTablero.Width / 3;

            colPendiente = CrearColumna(anchoColumna, "Pendiente", Color.AliceBlue);
            colPendiente.Location = new Point(0, 0);

            colEnProgreso = CrearColumna(anchoColumna, "En Progreso", Color.Black);
            colEnProgreso.Location = new Point(anchoColumna, 0);

            colCompletada = CrearColumna(anchoColumna, "Completada", Color.LightGreen);
            colCompletada.Location = new Point(2 * anchoColumna, 0);

            panelTablero.Controls.Add(colPendiente);
            panelTablero.Controls.Add(colEnProgreso);
            panelTablero.Controls.Add(colCompletada);

            foreach (var tarea in currentProject.tasks)
            {
                CrearTarjetaTarea(tarea);
            }
        }

        private FlowLayoutPanel CrearColumna(int ancho, string estado, Color color)
        {
            var col = new FlowLayoutPanel
            {
                Width = ancho - 20,
                Height = panelTablero.Height - 20,
                BackColor = color,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10),
                AutoScroll = true,
                AllowDrop = true

            };

            col.DragEnter += (s, e) => e.Effect = DragDropEffects.Move;
            col.DragDrop += (s, e) =>
            {
                var tarjeta = (Panel)e.Data.GetData(typeof(Panel));
                var tarea = (Task)tarjeta.Tag;

                if (Enum.TryParse(estado.Replace("", ""), true, out TaskState nuevoEstado))
                {
                    tarea.state = nuevoEstado;
                }
                else
                {
                    Console.WriteLine($"Error al asignar el estado: {estado}");
                }

                tarjeta.Parent.Controls.Remove(tarjeta);
                col.Controls.Add(tarjeta);
                GuardarProyecto(currentProject);
            };

            return col;

        }
        private void CrearTarjetaTarea(Task tarea)
        {
            Panel tarjeta = new Panel
            {
                Width = 320,
                Height = 120,
                Size = new Size(220, 100),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = tarea,
                Margin = new Padding(5)

            };

            Label lbl = new Label
            {
                Text = tarea.name,
                Dock = DockStyle.Top,
                Font = new Font("Rubik", 10, FontStyle.Bold),
                Height = 25,
            };

            tarjeta.Controls.Add(lbl);

            Point dragStart = Point.Empty;

            tarjeta.MouseDown += (s, e) =>
            {
                dragStart = e.Location;
            };

            tarjeta.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    int dist = Math.Abs(e.X - dragStart.X) + Math.Abs(e.Y - dragStart.Y);
                    if (dist > 10)
                        {
                        tarjeta.DoDragDrop(tarjeta, DragDropEffects.Move);
                    }
                }
            };

            buttonAgregar.Location = new Point(80, 60);
            buttonAgregar.Click += (s, e) =>
            {
                CreateSubtask formSub = new CreateSubtask(tarea.users);
                if (formSub.ShowDialog() == DialogResult.OK)
                {
                    SubTasks sub = formSub.SubTareaCreada as SubTasks;
                    sub.parentTaskId = tarea.id;
                    tarea.subTasks.Add(sub);

                    GuardarProyecto(currentProject);

                    Panel subTarjeta = new Panel
                    {
                        Width = tarjeta.Width - 20,
                        Height = 60,
                        BackColor = Color.LightCyan,
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = sub,
                        Margin = new Padding(5)
                    };

                    Label lblSub = new Label
                    {
                        Text = sub.name,
                        Dock = DockStyle.Top,
                        Height = 20
                    };
                    subTarjeta.Controls.Add(lblSub);

                    Button btnEditarSub = new Button { Text = "Editar", Width = 60, Height = 20, Top = 25, Left = 5 };
                    btnEditarSub.Click += (sender2, e2) =>
                    {
                        CreateSubtask formEditar = new CreateSubtask(sub.users);
                        formEditar.SubTareaEnEdicion = sub;
                        if (formEditar.ShowDialog() == DialogResult.OK)
                        {
                            lblSub.Text = sub.name;
                            GuardarProyecto(currentProject);
                        }
                    };
                    subTarjeta.Controls.Add(btnEditarSub);

                    Button btnEliminarSub = new Button { Text = "Eliminar", Width = 60, Height = 20, Top = 25, Left = 70 };
                    btnEliminarSub.Click += (sender2, e2) =>
                    {
                        tarea.subTasks.Remove(sub);
                        tarjeta.Controls.Remove(subTarjeta);
                        GuardarProyecto(currentProject);
                    };
                    subTarjeta.Controls.Add(btnEliminarSub);

                    tarjeta.Controls.Add(subTarjeta);
                }
            };

            buttonEditar.Location = new Point(120, 60);
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.Click += (s, e) =>
            {
                CreateTask formEditar = new CreateTask(currentProject.users, tarea);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {

                    Label lblDatos = tarjeta.Controls.OfType<Label>().First();
                    lblDatos.Text = tarea.name;

                    GuardarProyecto(currentProject);
                    MessageBox.Show("Tarea actualizada correctamente.");
                }
            };


            buttonEliminar.Location = new Point(160, 60);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.Click += (s, e) =>
            {
                DialogResult resultado = MessageBox.Show(
                    $"Are you sure you want to delete this task" + tarea.name,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                if (resultado == DialogResult.Yes)
                {
                    bool eliminada = currentProject.tasks.Remove(tarea);

                    if (eliminada)
                    {
                        tarjeta.Parent.Controls.Remove(tarjeta);
                        GuardarProyecto(currentProject);

                        MessageBox.Show("The task has been successfully deleted");
                    }
                    else
                    {
                        MessageBox.Show("The task couldn't be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            tarjeta.Controls.Add(buttonAgregar);
            tarjeta.Controls.Add(buttonEditar);
            tarjeta.Controls.Add(buttonEliminar);

            switch(tarea.state)
            {
                case TaskState.ToDo:
                    colPendiente.Controls.Add(tarjeta);
                    break;
                case TaskState.InProgress:
                    colEnProgreso.Controls.Add(tarjeta);
                    break;
                case TaskState.Complete:
                    colCompletada.Controls.Add(tarjeta);
                    break;
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

                    proyectos = proyectos.Select(p => p.id == proyectoActual.id ? proyectoActual : p).ToList();
                }
            }
            else
            {
                proyectos.Add(proyectoActual);
            }

            var dateConverter = new CustomDateTimeConverter2();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter> { dateConverter }
            };

            string nuevoJson = JsonConvert.SerializeObject(proyectos, settings);
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
