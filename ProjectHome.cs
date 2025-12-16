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
        private Point dragStart = Point.Empty;

        public ProjectHome(Project project)
        {
            InitializeComponent();

            currentProject = project;

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

            ConfigurarMenu();

        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            Logo.Size = new Size(250, 85);
            Logo.Location = new Point((this.ClientSize.Width - Logo.Width) / 2, 60);

            int detailsPanelX = (this.ClientSize.Width - panelDetails.Width) / 10;
            int panelY = 180;
            const int SPACING = 20;

            panelDetails.Size = new Size(300, 850);
            panelDetails.Location = new Point(detailsPanelX, panelY);
            panelDetails.Controls.Clear();

            buttonCrearTarea.BringToFront();
            buttonCrearTarea.Size = new Size(250, 40);
            buttonCrearTarea.Font = Fuentes.RubikBold(15);
            buttonCrearTarea.BackColor = Color.FromArgb(229, 122, 122);
            buttonCrearTarea.ForeColor = Color.FromArgb(255, 251, 249);
            buttonCrearTarea.Location = new Point((panelDetails.Width - buttonCrearTarea.Width) / 2, 530);
            panelDetails.Controls.Add(buttonCrearTarea);

            buttonEditProject.BringToFront();
            buttonEditProject.Size = new Size(250, 40);
            buttonEditProject.Font = Fuentes.RubikBold(15);
            buttonEditProject.BackColor = Color.FromArgb(211, 145, 109);
            buttonEditProject.ForeColor = Color.FromArgb(255, 251, 249);
            buttonEditProject.Location = new Point((panelDetails.Width - buttonEditProject.Width) / 2, 580);
            panelDetails.Controls.Add(buttonEditProject);

            FlowLayoutPanel flpContenido = new FlowLayoutPanel
            {
                Width = panelDetails.Width - 10,
                Height = panelDetails.Height - 10,
                Location = new Point(0, 0),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = false
            };

            panelDetails.Controls.Add(flpContenido);

            labelTitulo2.Font = Fuentes.Calistoga(25);
            labelTitulo2.ForeColor = Color.FromArgb(61, 23, 0);
            labelTitulo2.Dock = DockStyle.Top;
            labelTitulo2.TextAlign = ContentAlignment.MiddleCenter;
            labelTitulo2.Margin = new Padding(10, 20, 0, 10);
            flpContenido.Controls.Add(labelTitulo2);

            labelNameProject.Text = currentProject.name;
            labelNameProject.Font = Fuentes.RubikBold(20);
            labelNameProject.ForeColor = Color.FromArgb(211, 145, 109);
            labelNameProject.AutoSize = true;
            labelNameProject.Dock = DockStyle.Top;
            labelNameProject.TextAlign = ContentAlignment.MiddleCenter;
            labelNameProject.Margin = new Padding(0, 20, 0, 10);
            flpContenido.Controls.Add(labelNameProject);

            labelDescriptionProject.Text = currentProject.description;
            labelDescriptionProject.Font = Fuentes.RubikRegular(12);
            labelDescriptionProject.ForeColor = Color.FromArgb(61, 23, 0);
            labelDescriptionProject.AutoSize = true;
            labelDescriptionProject.MaximumSize = new Size(flpContenido.Width - 10, 0);
            labelDescriptionProject.Dock = DockStyle.Top;
            labelDescriptionProject.TextAlign = ContentAlignment.MiddleCenter;
            flpContenido.Controls.Add(labelDescriptionProject);

            Label lblParticipantes = new Label
            {
                Text = "Team Members",
                Font = Fuentes.RubikBold(15),
                BackColor = Color.FromArgb(229, 122, 122),
                ForeColor = Color.FromArgb(255, 251, 249),
                AutoSize = true,
                Margin = new Padding(30, 30, 5, 10)
            };
            flpContenido.Controls.Add(lblParticipantes);
            TableLayoutPanel tlpUsuarios = CrearTablaUsuarios(currentProject, flpContenido.Width);
            flpContenido.Controls.Add(tlpUsuarios);

            Panel panelFechas = new Panel
            {
                Width = flpContenido.Width - 10,
                Height = 60,
                Margin = new Padding(0, 20, 0, 0)
            };

            labelStartDate.Text = "Start date: " + currentProject.startDate.ToString("dd/MM/yyyy");
            labelStartDate.ForeColor = Color.FromArgb(211, 145, 109);
            labelStartDate.Font = Fuentes.RubikBold(12);
            labelStartDate.AutoSize = true;

            labelEndDate.Text = "DeadLine: " + currentProject.endDate.ToString("dd/MM/yyyy");
            labelEndDate.ForeColor = Color.FromArgb(211, 145, 109);
            labelEndDate.Font = Fuentes.RubikBold(12);
            labelEndDate.AutoSize = true;

            labelStartDate.Location = new Point(25, 5);
            labelEndDate.Location = new Point(25, 30);

            panelFechas.Controls.Add(labelStartDate);
            panelFechas.Controls.Add(labelEndDate);
            flpContenido.Controls.Add(panelFechas);

            InicializarTablero(detailsPanelX, panelY, SPACING, panelDetails.Width);


        }

        private TableLayoutPanel CrearTablaUsuarios(Project project, int anchoContenedor)
        {
            List<InfoUser> todosUsuarios = UsuarioManager.LeerUsuarios();

            var miembros = todosUsuarios.Where(u => project.users.Contains(u.id)).ToList();

            if (miembros.Count == 0)
            {
                return new TableLayoutPanel { Controls = { new Label { Text = "No hay usuarios asignados.", AutoSize = true } }, Width = 280, AutoSize = true };
            }

            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Width = anchoContenedor - 10,
                AutoSize = true,
                ColumnCount = 2,
                RowCount = miembros.Count,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Padding = new Padding(5)
            };

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            int row = 0;
            foreach (var usuario in miembros)
            {
                Label lblBullet = new Label
                {
                    Text = "•",
                    Font = Fuentes.RubikBold(12),
                    ForeColor = Color.FromArgb(229, 122, 122),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label lblName = new Label
                {
                    Text = usuario.username,
                    Font = Fuentes.RubikRegular(12),
                    ForeColor = Color.FromArgb(61, 23, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                tlp.Controls.Add(lblBullet, 0, row);
                tlp.Controls.Add(lblName, 1, row);

                tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                row++;
            }

            return tlp;
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
            this.Close();
        }

        private void IrAUsuarios()
        {
            Users formUsuarios = new Users();
            formUsuarios.Show();
            this.Close();
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

        private void InicializarTablero(int detailsPanelX, int panelY, int spacing, int detailsWidth)
        {

            int tableroPanelX = detailsPanelX + detailsWidth + spacing;
            panelTablero = new Panel
            {
                Size = new Size(1200, 850),
                Location = new Point(tableroPanelX, panelY),
                BackColor = Color.FromArgb(255, 251, 249),
                AutoScroll = true
            };

            this.Controls.Add(panelTablero);

            int anchoColumna = panelTablero.Width / 3;

            colPendiente = CrearColumna(anchoColumna, "To Do", Color.FromArgb(233,159,159));
            colPendiente.Location = new Point(0, 0);

            colEnProgreso = CrearColumna(anchoColumna, "In Progress", Color.FromArgb(250,213,180));
            colEnProgreso.Location = new Point(anchoColumna, 0);

            colCompletada = CrearColumna(anchoColumna, "Complete", Color.FromArgb(201, 210, 156));
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

                if (Enum.TryParse(estado.Replace(" ", ""), true, out TaskState nuevoEstado))
                {
                    tarea.state = nuevoEstado;

                    tarjeta.Parent.Controls.Remove(tarjeta);
                    col.Controls.Add(tarjeta);
                    GuardarProyecto(currentProject);
                }
                else
                {
                    MessageBox.Show($"No se pudo convertir '{estado}' al Enum. Revisa que el nombre coincida.");
                }
            };

            return col;

        }
        private void CrearTarjetaTarea(Task tarea)
        {
            Panel tarjeta = new Panel
            {
                Width = 350,
                MinimumSize = new Size(350, 100),
                BackColor = Color.FromArgb(255, 251, 249),
                BorderStyle = BorderStyle.None,
                Tag = tarea,
                Margin = new Padding(5),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink

            };

            FlowLayoutPanel flpSubTareas = new FlowLayoutPanel
            {
                Width = tarjeta.Width - 10,
                Height = 0,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Visible = false,
                Dock = DockStyle.Top
            };

            Panel panelCabecera = new Panel
            {
                Width = tarjeta.Width,
                Height = 100,
                BackColor = Color.Transparent,
                Dock = DockStyle.Top
            };

            Button ver = new Button
            {
                Text = "▼",
                Tag = false,
                Size = new Size(25, 25),
                Location = new Point(5, 7),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            ver.Click += (s, e) =>
            {
                ToggleSubtasks(flpSubTareas, ver);
            };

            Label labelNombre = new Label
            {
                Text = tarea.name,
                Font = Fuentes.RubikBold(15),
                ForeColor = Color.FromArgb(61, 23, 0),
                Location = new Point(60, 50),
                AutoSize = true,
            };

            Button btnAgregarSub = new Button { Text = "+", Size = new Size(30, 30), Font = Fuentes.RubikRegular(15), Location = new Point(panelCabecera.Width - 90, 3), FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0 }, ForeColor = Color.FromArgb(61, 23, 0) };
            Button btnEditarTarea = new Button { Text = "✎", Size = new Size(30, 30), Font = Fuentes.RubikRegular(15), Location = new Point(panelCabecera.Width - 60, 3), FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0 }, ForeColor = Color.FromArgb(61, 23, 0) };
            Button btnEliminarTarea = new Button { Text = "✕", Size = new Size(30, 30), Font = Fuentes.RubikRegular(15), Location = new Point(panelCabecera.Width - 30, 3), FlatStyle = FlatStyle.Flat, ForeColor = Color.FromArgb(229, 122, 122), FlatAppearance = { BorderSize = 0 } };

            btnAgregarSub.Click += (s, e) => buttonAgregar_Click(s, e, tarea, flpSubTareas);

            btnEditarTarea.Click += (s, e) => buttonEditar_Click(s, e, tarea, labelNombre, tarjeta);

            btnEliminarTarea.Click += (s, e) => buttonEliminar_Click(s, e, tarea, tarjeta);
            
            panelCabecera.Controls.Add(ver);
            panelCabecera.Controls.Add(labelNombre);
            panelCabecera.Controls.Add(btnAgregarSub); 
            panelCabecera.Controls.Add(btnEditarTarea); 
            panelCabecera.Controls.Add(btnEliminarTarea);

            tarjeta.Controls.Add(panelCabecera);
            tarjeta.Controls.Add(flpSubTareas);

            MouseEventHandler mouseDownHandler = (s, e) => Tarjeta_MouseDown(s, e, tarjeta);
            MouseEventHandler mouseMoveHandler = (s, e) => Tarjeta_MouseMove(s, e, tarjeta);

            tarjeta.MouseDown += mouseDownHandler;
            tarjeta.MouseMove += mouseMoveHandler;
            panelCabecera.MouseDown += mouseDownHandler;
            panelCabecera.MouseMove += mouseMoveHandler;
            labelNombre.MouseDown += mouseDownHandler;
            labelNombre.MouseMove += mouseMoveHandler;

            foreach (var subTarea in tarea.subTasks)
            {
                CrearSubTareaCard(subTarea, flpSubTareas, tarea);
            }

            ColocarTarjetaEnColumna(tarjeta, tarea.state);

        }

        private void Tarjeta_MouseDown(object sender, MouseEventArgs e, Panel tarjeta)
        {
            dragStart = e.Location;
        }

        private void Tarjeta_MouseMove(object sender, MouseEventArgs e, Panel tarjeta)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dist = Math.Abs(e.X - dragStart.X) + Math.Abs(e.Y - dragStart.Y);
                if (dist > 10)
                {
                    tarjeta.DoDragDrop(tarjeta, DragDropEffects.Move);
                }
            }
        }

        public void GuardarProyecto(Project proyectoActual)
        {
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Json", "projects.json");

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

        private void buttonEditar_Click(object sender, EventArgs e, Task task, Label labelNombre, Panel tarjeta)
        {
            TaskState estadoAnterior = task.state;

            CreateTask formEditar = new CreateTask(currentProject.users, task);
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                labelNombre.Text = task.name;
                GuardarProyecto(currentProject);

                if (task.state != estadoAnterior)
                {
                    tarjeta.Parent.Controls.Remove(tarjeta);
                    ColocarTarjetaEnColumna(tarjeta, task.state);
                }

                MessageBox.Show("Task updated successfully.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e, Task task, Panel tarjeta)
        {
            DialogResult resultado = MessageBox.Show(
                "Are you sure you want to delete this task?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (currentProject.tasks.Remove(task))
            {
                tarjeta.Parent.Controls.Remove(tarjeta);
                GuardarProyecto(currentProject);
                MessageBox.Show("Task deleted successfully.");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e, Task task, FlowLayoutPanel flpSubTarea)
        {
            CreateSubtask formSub = new CreateSubtask(task.users);
            if (formSub.ShowDialog() == DialogResult.OK)
            {
                SubTasks subTask = formSub.SubTareaCreada as SubTasks;
                subTask.parentTaskId = task.id;
                task.subTasks.Add(subTask);
                GuardarProyecto(currentProject);

                CrearSubTareaCard(subTask, flpSubTarea, task);
            }
        }

        private void CrearSubTareaCard(SubTasks sub, FlowLayoutPanel contenedorSubTask, Task task)
        {
            Panel subTarjeta = new Panel
            {
                Width = contenedorSubTask.Width - 5,
                Height = 40,
                BackColor = Color.FromArgb(252, 250, 249),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = sub,
                Margin = new Padding(5)
            };

            Label labelNombre = new Label
            {
                Text = sub.name,
                Dock = DockStyle.Left,
                Height = 20,
                Font = Fuentes.RubikRegular(15),
                ForeColor = Color.FromArgb(61, 23, 0),
                Location = new Point(10, 10),
                AutoSize = true,
            };
            subTarjeta.Controls.Add(labelNombre);

            Button btnEditSub = new Button { Text = "✎", Size = new Size(25, 20), Font = Fuentes.RubikRegular(15), Location = new Point(subTarjeta.Width - 60, 5), FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0 }, ForeColor = Color.FromArgb(61, 23, 0) };
            Button btnDeleteSub = new Button { Text = "✕", Size = new Size(25, 20), Font = Fuentes.RubikRegular(15), Location = new Point(subTarjeta.Width - 30, 5), FlatStyle = FlatStyle.Flat, ForeColor = Color.FromArgb(229, 122, 122), FlatAppearance = { BorderSize = 0 } };

            btnEditSub.Click += (s, e) => buttonEditSub_Click(s, e, sub, labelNombre, task);

            btnDeleteSub.Click += (s, e) => buttonDeleteSub_Click(s, e, sub, subTarjeta, task);

            subTarjeta.Controls.Add(btnEditSub);
            subTarjeta.Controls.Add(btnDeleteSub);
            contenedorSubTask.Controls.Add(subTarjeta);
        }

        private void buttonEditProject_Click(object sender, EventArgs e)
        {
            //CreateProject formEditar = new CreateProject(currentProject);
            //if (formEditar.ShowDialog() == DialogResult.OK)
            //{
            //    currentProject = formEditar.ProyectoCreado;
            //    GuardarProyecto(currentProject);
            //    labelNameProject.Text = currentProject.name;
            //    labelDescriptionProject.Text = currentProject.description;
            //    MessageBox.Show("Project updated successfully.");
            //}
        }

        private void buttonEditSub_Click(object sender, EventArgs e, SubTasks sub, Label labelSub, Task task)
        {
            CreateSubtask formEditar = new CreateSubtask(sub.users, sub);

            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                labelSub.Text = sub.name;
                GuardarProyecto(currentProject);
                MessageBox.Show("Subtask updated successfully.");
            }
        }

        private void buttonDeleteSub_Click(object sender, EventArgs e, SubTasks sub, Panel subTarjeta, Task task)
        {
            task.subTasks.Remove(sub);
            subTarjeta.Parent.Controls.Remove(subTarjeta); 
            GuardarProyecto(currentProject);
        }

        private void ColocarTarjetaEnColumna(Panel tarjeta, TaskState state)
        {
            FlowLayoutPanel columna;

            switch (state)
            {
                case TaskState.ToDo:
                    columna = colPendiente;
                    break;

                case TaskState.InProgress:
                    columna = colEnProgreso;
                    break;

                case TaskState.Complete:
                    columna = colCompletada;
                    break;

                default:
                    columna = colPendiente;
                    break;
            }

            columna.Controls.Add(tarjeta);
        }

        private void ToggleSubtasks(FlowLayoutPanel flpSubtareas, Button btnExpandir)
        {
            bool isExpanded = (bool)btnExpandir.Tag;

            int targetHeight = isExpanded ? 0 : 150;

            flpSubtareas.Visible = !isExpanded;
            flpSubtareas.Height = targetHeight;
            btnExpandir.Text = isExpanded ? "▼" : "▲";
            btnExpandir.Tag = !isExpanded;

            // Opcional: Redimensionar la tarjeta principal si es necesario
            // ((Panel)flpSubtareas.Parent).Height = 100 + targetHeight; 
        }
    }
}
