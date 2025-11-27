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
        public OpenProject()
        {
            InitializeComponent();
            inicializarListBox();
            cargarProjects();
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 900);
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
        }

        private void inicializarListBox() 
        { 
            listBoxProjects = new ListBox();
            listBoxProjects.Location = new Point(50, 50);
            listBoxProjects.Font = Fuentes.RubikRegular(12);
            listBoxProjects.DoubleClick += listBoxProjects_DoubleClick;
            this.Controls.Add(listBoxProjects);
        }

        private void listBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxProjects_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxProjects.SelectedIndex;
            if (index >= 0 && index < projects.Count)
            {
                Project selectedProject = projects[index];
                ProjectHome projectHomeForm = new ProjectHome(selectedProject);
                projectHomeForm.Show();
            }

        }

        private void cargarProjects()
        {
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Json", "Proyectos.json");

            if (File.Exists(rutaJson))
            {
                string contenido = File.ReadAllText(rutaJson);
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    projects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Project>>(contenido);

                    listBoxProjects.Items.Clear();
                    foreach (var project in projects)
                    {
                        listBoxProjects.Items.Add(project.name);
                    }
                }
            }
            else
            { 
                projects = new List<Project>();
            }
        }
    }
}
