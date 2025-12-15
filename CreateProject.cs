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

            this.Size = new Size(650, 800);
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

            panelFormulario.Location = new Point((this.Width - panelFormulario.Width) / 2, 60);
            labelTitulo.Font = Fuentes.Calistoga(40);
            labelTitulo.Location = new Point((this.panelFormulario.Width - labelTitulo.Width) / 2, 5);
            labelTitulo.ForeColor = Color.FromArgb(92, 135, 153);

            labelNombreProyecto.Font = Fuentes.RubikBold(12);
            labelNombreProyecto.Location = new Point(this.panelFormulario.Width / 8, 130);
            labelNombreProyecto.ForeColor = Color.FromArgb(92, 135, 153);
            textBoxNombreProyecto.Font = Fuentes.RubikRegular(12);
            textBoxNombreProyecto.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxNombreProyecto.Location = new Point(this.panelFormulario.Width / 3, 130);
            textBoxNombreProyecto.Multiline = true;
            textBoxNombreProyecto.Height = 25;
            textBoxNombreProyecto.KeyPress += (s, i) => {
                if (i.KeyChar == (char)Keys.Enter)
                {
                    i.Handled = true;
                }
            };

            labelDescripcionProyecto.Font = Fuentes.RubikBold(12);
            labelDescripcionProyecto.Location = new Point(this.panelFormulario.Width / 8, 175);
            labelDescripcionProyecto.ForeColor = Color.FromArgb(92, 135, 153);
            textBoxDescripcionProyecto.Font = Fuentes.RubikRegular(12);
            textBoxDescripcionProyecto.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxDescripcionProyecto.Location = new Point(this.panelFormulario.Width / 3, 175);
            textBoxDescripcionProyecto.Multiline = true;
            textBoxDescripcionProyecto.Height = 85;

            labelFechaInicio.Font = Fuentes.RubikBold(12);
            labelFechaInicio.Location = new Point(this.panelFormulario.Width / 8, 285);
            labelFechaInicio.ForeColor = Color.FromArgb(92, 135, 153);
            labelFechaInicio.BringToFront();
            dateTimePickerInicio.Font = Fuentes.RubikRegular(12);
            dateTimePickerInicio.Location = new Point(this.panelFormulario.Width / 3, 285);


            labelFechaFin.Font = Fuentes.RubikBold(12);
            labelFechaFin.Location = new Point(this.panelFormulario.Width / 8, 325);
            labelFechaFin.ForeColor = Color.FromArgb(92, 135, 153);
            dateTimePickerFin.Font = Fuentes.RubikRegular(12);
            dateTimePickerFin.Location = new Point(this.panelFormulario.Width / 3, 325);

            labelAñadirUsuarios.Font = Fuentes.RubikBold(20);
            labelAñadirUsuarios.Location = new Point(this.panelFormulario.Width / 3, 375);
            labelAñadirUsuarios.ForeColor = Color.FromArgb(92, 135, 153);

            listaUsuarios = new ListView();
            listaUsuarios.View = View.Details;
            listaUsuarios.BackColor = Color.FromArgb(252, 250, 249);
            listaUsuarios.ForeColor = Color.FromArgb(61, 23, 0);
            listaUsuarios.Font = Fuentes.RubikRegular(12);
            listaUsuarios.CheckBoxes = true;
            listaUsuarios.GridLines = false;
            listaUsuarios.FullRowSelect = true;
            listaUsuarios.Size = new Size(panelFormulario.Width - 190, 180);
            listaUsuarios.Location = new Point(this.panelFormulario.Width / 7, 420); 
            listaUsuarios.Columns.Add("Users", 260);
            listaUsuarios.Columns.Add("Rol", 180);

            int spacing = 20;
            int totalWidth = buttonCrearProyecto.Width + buttonCancelar.Width + spacing;

            int startX = (panelFormulario.Width - totalWidth) / 4;

            buttonCrearProyecto.Font = Fuentes.RubikBold(15);
            buttonCrearProyecto.Size = new Size(210, 50);
            buttonCrearProyecto.Location = new Point(startX, 630);
            buttonCrearProyecto.ForeColor = Color.FromArgb(252, 250, 249);
            buttonCrearProyecto.BackColor = Color.FromArgb(204, 163, 193);

            buttonCancelar.Font = Fuentes.RubikBold(15);
            buttonCancelar.Size = new Size(210, 50);
            buttonCancelar.Location = new Point(startX + buttonCrearProyecto.Width + spacing, 630);
            buttonCancelar.ForeColor = Color.FromArgb(252, 250, 249);
            buttonCancelar.BackColor = Color.FromArgb(211, 145, 109);

            panelFormulario.Controls.Add(listaUsuarios);
            string rutaJson = Path.Combine(Application.StartupPath, "Json", "Usuarios.json");
            usuariosRegistrados = CargarUsuariosDesdeJson(rutaJson);


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
                MessageBox.Show("Please enter a name for the project.");
                textBoxNombreProyecto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescripcionProyecto.Text))
            {
                MessageBox.Show("Please enter a description for the project.");
                textBoxDescripcionProyecto.Focus();
                return;
            }


            DateTime start = dateTimePickerInicio.Value.Date;
            DateTime end = dateTimePickerFin.Value.Date;

            if (end < start)
            {
                MessageBox.Show("The end date cannot be earlier than the start date.");
                return;
            }

            var miembros = ObtenerUsuariosSeleccionados();
            if (miembros.Count == 0)
            {
                MessageBox.Show("Please select at least one member for the project.");
                return;
            }

            List<string> idsMiembros = miembros.Select(u => u.id).ToList();

            Project proyecto = new Project
            {
                id = Guid.NewGuid().ToString(),
                name = textBoxNombreProyecto.Text,
                description = textBoxDescripcionProyecto.Text,
                startDate = start,
                endDate = end,
                users = idsMiembros,
                tasks = new List<Task>()
            };

            string nuevoProyectoId = proyecto.id;
            List<InfoUser> usuariosGlobales = UsuarioManager.LeerUsuarios();

            foreach (var miembroSeleccionado in miembros)
            {
                var usuarioActualizar = usuariosGlobales.FirstOrDefault(u => u.id == miembroSeleccionado.id);

                if (usuarioActualizar != null)
                {
                    if (!usuarioActualizar.projects.Contains(nuevoProyectoId))
                    {
                        usuarioActualizar.projects.Add(nuevoProyectoId);
                    }
                }
            }

            UsuarioManager.GuardarUsuarios(usuariosGlobales);

            GuardarProyecto(proyecto);
            MessageBox.Show("The project has been created successfully.");
            ProjectHome projectHome = new ProjectHome(proyecto);
            projectHome.Show();

        }

        public void GuardarProyecto(Project proyecto)
        {
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Json", "projects.json");
            List<Project> proyectos = new List<Project>();

            if (File.Exists(rutaJson))
            {
                string contenido = File.ReadAllText(rutaJson);
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    proyectos = JsonConvert.DeserializeObject<List<Project>>(contenido);
                    proyectos = proyectos.Where(p => p.name != "Name").ToList();
                }
            }

            proyectos.Add(proyecto);

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter>
                {
                    new CustomDateTimeConverter2()
                }
            };

            string nuevoJson = JsonConvert.SerializeObject(proyectos, settings);
            File.WriteAllText(rutaJson, nuevoJson);


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
