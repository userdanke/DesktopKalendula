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

namespace DesktopKalendula
{
    public partial class OpenProject : Form
    {
        private Button btnCerrar;
        private Button btnMinimizar;
        private List<Project> projects;
        private FlowLayoutPanel FlowLayoutPanelProjects;
        public OpenProject()
        {
            InitializeComponent();
            inicializarContenedor();
            cargarProjects();
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 600);
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            btnCerrar = new Button();
            btnCerrar.Text = "✕";
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.ForeColor = Color.FromArgb(61, 23, 0);
            btnCerrar.Font = Fuentes.RubikRegular(15);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Size = new Size(80, 30);
            btnCerrar.Click += (s, i) => this.Close();

            btnMinimizar = new Button();
            btnMinimizar.Text = "⎯";
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.ForeColor = Color.FromArgb(61, 23, 0);
            btnMinimizar.Font = Fuentes.RubikRegular(15);
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.Size = new Size(80, 30);
            btnMinimizar.Click += (s, i) => this.FindForm().WindowState = FormWindowState.Minimized;

            btnCerrar.Location = new Point(this.Width - btnCerrar.Width - 10, 5);
            btnMinimizar.Location = new Point(this.Width - btnCerrar.Width - btnMinimizar.Width - 15, 5);

            this.Controls.Add(btnCerrar);
            this.Controls.Add(btnMinimizar);

            labelTitulo.Font = Fuentes.Calistoga(40);
            labelTitulo.Location = new Point((this.Width - labelTitulo.Width) / 2, 80);
            labelTitulo.ForeColor = Color.FromArgb(92, 135, 153);
        }

        private void inicializarContenedor()
        {
            FlowLayoutPanelProjects = new FlowLayoutPanel();
            FlowLayoutPanelProjects.Size = new Size(500, 400);
            FlowLayoutPanelProjects.Font = Fuentes.RubikRegular(20);
            FlowLayoutPanelProjects.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanelProjects.WrapContents = false;
            FlowLayoutPanelProjects.AutoScroll = true;
            FlowLayoutPanelProjects.Location = new Point(this.Width /7, 200);
            this.Controls.Add(FlowLayoutPanelProjects);
        }

        private void cargarProjects()
        {
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Json", "projects.json");

            if (File.Exists(rutaJson))
            {
                string contenido = File.ReadAllText(rutaJson);
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    projects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Project>>(contenido);

                    FlowLayoutPanelProjects.Controls.Clear();
                    foreach (var project in projects)
                    {
                        CrearPanelProyecto(project);
                    }
                }
            }
            else
            {
                projects = new List<Project>();
            }
        }

        private void CrearPanelProyecto(Project project)
        {
            Panel panelProyecto = new Panel
            {
                Width = FlowLayoutPanelProjects.Width - 40,
                Height = 80,
                BackColor = Color.FromArgb(204, 163, 193),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(5)
            };

            panelProyecto.Tag = project;

            Label labelNombre = new Label
            {
                Text = project.name,
                Font = Fuentes.RubikBold(20),
                ForeColor = Color.FromArgb(252, 250, 249),
                Location = new Point(10, 5),
                AutoSize = true,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label fechaInicio = new Label
            {
                Text = "Start on : " + project.startDate.ToString("dd/MM/yyyy"),
                Font = Fuentes.RubikRegular(10),
                ForeColor = Color.FromArgb(167, 104, 150),
                Location = new Point(15, 50),
                AutoSize = true,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label fechaFin = new Label
            {
                Text = "End on : " + project.endDate.ToString("dd/MM/yyyy"),
                Font = Fuentes.RubikRegular(10),
                ForeColor = Color.FromArgb(167, 104, 150),
                Location = new Point(300, 50),
                AutoSize = true,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelProyecto.Click += PanelProyecto_Click;
            labelNombre.Click += PanelProyecto_Click;

            panelProyecto.Controls.Add(fechaFin);
            panelProyecto.Controls.Add(labelNombre);
            panelProyecto.Controls.Add(fechaInicio);
            FlowLayoutPanelProjects.Controls.Add(panelProyecto);

        }

        private void PanelProyecto_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Panel projectPanel = control as Panel ?? control.Parent as Panel;

            if (projectPanel != null && projectPanel.Tag is Project selectedProject)
            {
                ProjectHome projectHomeForm = new ProjectHome(selectedProject);
                projectHomeForm.Show();
            }
        }
    }
}

