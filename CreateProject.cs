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
    public partial class CreateProject : Form
    {
        private Button btnCerrar;
        private Button btnMinimizar;
        private ListView listaUsuarios;
        private List<InfoUser> usuariosRegistrados;
        public CreateProject()
        {
            InitializeComponent();
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {

            this.Size = new Size(900, 900);
            this.StartPosition = FormStartPosition.CenterScreen;

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

            panelFormulario.Location = new Point((this.Width - panelFormulario.Width) / 2, 100);
            labelTitulo.Font = Fuentes.RubikBold(25);
            labelTitulo.Location = new Point((panelFormulario.Width - labelTitulo.Width) / 2, 20);
            labelTitulo.ForeColor = Color.FromArgb(92, 135, 153);

            labelNombreProyecto.Font = Fuentes.RubikRegular(12);
            labelNombreProyecto.Location = new Point(this.panelFormulario.Width / 10, 110);
            labelNombreProyecto.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxNombreProyecto.Font = Fuentes.RubikRegular(12);
            textBoxNombreProyecto.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxNombreProyecto.Location = new Point(this.panelFormulario.Width / 9, 140);
            textBoxNombreProyecto.Multiline = true;
            textBoxNombreProyecto.Height = 25;
            textBoxNombreProyecto.KeyPress += (s, i) => {
                if (i.KeyChar == (char)Keys.Enter)
                {
                    i.Handled = true;
                }
            };

            labelDescripcionProyecto.Font = Fuentes.RubikRegular(12);
            labelDescripcionProyecto.Location = new Point(this.panelFormulario.Width / 10, 180);
            labelDescripcionProyecto.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxDescripcionProyecto.Font = Fuentes.RubikRegular(12);
            textBoxDescripcionProyecto.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxDescripcionProyecto.Location = new Point(this.panelFormulario.Width / 9, 210);
            textBoxDescripcionProyecto.Multiline = true;
            textBoxDescripcionProyecto.Height = 85;

            labelFechaInicio.Font = Fuentes.RubikRegular(12);
            labelFechaInicio.Location = new Point(this.panelFormulario.Width / 10, 320);
            labelFechaInicio.ForeColor = Color.FromArgb(61, 23, 0);
            labelFechaInicio.BringToFront();
            dateTimePickerInicio.Font = Fuentes.RubikRegular(12);
            dateTimePickerInicio.Location = new Point(this.panelFormulario.Width / 9, 350);


            labelFechaFin.Font = Fuentes.RubikRegular(12);
            labelFechaFin.Location = new Point(this.panelFormulario.Width / 10, 390);
            labelFechaFin.ForeColor = Color.FromArgb(61, 23, 0);
            dateTimePickerFin.Font = Fuentes.RubikRegular(12);
            dateTimePickerFin.Location = new Point(this.panelFormulario.Width / 9, 420);

            int spacing = 20;
            int totalWidth = buttonCrearProyecto.Width + buttonCancelar.Width + spacing;

            int startX = (panelFormulario.Width - totalWidth) / 5;

            buttonCrearProyecto.Font = Fuentes.RubikBold(15);
            buttonCrearProyecto.Size = new Size(210, 50);
            buttonCrearProyecto.Location = new Point(startX, 480);
            buttonCrearProyecto.ForeColor = Color.FromArgb(252, 250, 249);
            buttonCrearProyecto.BackColor = Color.FromArgb(204, 163, 193);

            buttonCancelar.Font = Fuentes.RubikBold(15);
            buttonCancelar.Size = new Size(210, 50);
            buttonCancelar.Location = new Point(startX + buttonCrearProyecto.Width + spacing, 480);
            buttonCancelar.ForeColor = Color.FromArgb(252, 250, 249);
            buttonCancelar.BackColor = Color.FromArgb(211, 145, 109);

            listaUsuarios = new ListView();
            listaUsuarios.View = View.Details;
            listaUsuarios.CheckBoxes = true;
            listaUsuarios.FullRowSelect = true;
            listaUsuarios.Size = new Size(panelFormulario.Width - 40, 180);
            listaUsuarios.Location = new Point(20, 500); 
            listaUsuarios.Columns.Add("Usuario", 150);
            listaUsuarios.Columns.Add("Rol", 100);
            listaUsuarios.Columns.Add("Email", 200);

            panelFormulario.Controls.Add(listaUsuarios);
            string rutaJson = Path.Combine(Application.StartupPath, "Json", "Usuarios.json");
            usuariosRegistrados = CargarUsuariosDesdeJson(rutaJson);
            MostrarUsuariosEnLista();
            MostrarUsuariosEnLista();
        }

        private void labelFechaInicio_Click(object sender, EventArgs e)
        {

        }

        public List<InfoUser> CargarUsuariosDesdeJson(string ruta)
        {
            if (!File.Exists(ruta))
                return new List<InfoUser>();

            string json = File.ReadAllText(ruta);
            return JsonConvert.DeserializeObject<List<InfoUser>>(json);
        }

        private void MostrarUsuariosEnLista()
        {
            listaUsuarios.Items.Clear();

            foreach (var user in usuariosRegistrados)
            {
                ListViewItem item = new ListViewItem(user.username);
                item.SubItems.Add(user.role);
                item.SubItems.Add(user.email);
                item.Tag = user; 
                listaUsuarios.Items.Add(item);
            }
        }

        private List<InfoUser> ObtenerUsuariosSeleccionados()
        {
            List<InfoUser> seleccionados = new List<InfoUser>();

            foreach (ListViewItem item in listaUsuarios.Items)
            {
                if (item.Checked)
                    seleccionados.Add((InfoUser)item.Tag);
            }

            return seleccionados;
        }

        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxNombreProyecto.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el proyecto.");
                textBoxNombreProyecto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescripcionProyecto.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción para el proyecto.");
                textBoxDescripcionProyecto.Focus();
                return;
            }


            if (dateTimePickerFin.Value < dateTimePickerInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser igual a la fecha de inicio.");
                dateTimePickerFin.Focus();
                return;
            }

            var miembros = ObtenerUsuariosSeleccionados();
            if (miembros.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un miembro para el proyecto.");
                return;
            }

            List<string> emailsMiembros = miembros.Select(u => u.email).ToList();

            Project proyecto = new Project
            {
                Id = Guid.NewGuid().ToString(),
                Name = textBoxNombreProyecto.Text,
                Description = textBoxDescripcionProyecto.Text,
                StartDate = dateTimePickerInicio.Value,
                EndDate = dateTimePickerFin.Value,
                users = emailsMiembros,
                Tasks = new List<Task>()
            };

            GuardarProyecto(proyecto);
            MessageBox.Show("Proyecto creado exitosamente.");
            ProjectHome projectHome = new ProjectHome(proyecto);
            projectHome.Show();

        }

        public void GuardarProyecto(Project proyecto)
        {
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Json", "Proyectos.json");
            List<Project> proyectos = new List<Project>();

            if (File.Exists(rutaJson))
            {
                string contenido = File.ReadAllText(rutaJson);
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    proyectos = JsonConvert.DeserializeObject<List<Project>>(contenido);
                    proyectos = proyectos.Where(p => p.Name !="Name").ToList();
                }
            }

            proyectos.Add(proyecto);

            string nuevoJson = JsonConvert.SerializeObject(proyectos, Formatting.Indented);
            File.WriteAllText(rutaJson, nuevoJson);


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
