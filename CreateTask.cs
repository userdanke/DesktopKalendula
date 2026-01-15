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
    public partial class CreateTask : Form
    {
        private Button btnCerrar;
        private Button btnMinimizar;
        private List<string> usuariosDisponibles;
        public Task TareaCreada { get; private set; }
        public Task TareaEnEdicion;
        private ListView listaUsuarios;
        private List<InfoUser> usuariosRegistrados;
        public CreateTask(List<string> userId, Task tareaEditar = null)
        {
            InitializeComponent();
            usuariosDisponibles = userId;
            TareaEnEdicion = tareaEditar;
        }

        private void CreateTask_Load(object sender, EventArgs e)
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

            labelNombreTarea.Font = Fuentes.RubikBold(12);
            labelNombreTarea.Location = new Point(this.panelFormulario.Width / 6, 130);
            labelNombreTarea.ForeColor = Color.FromArgb(92, 135, 153);

            textBoxNombreTarea.Font = Fuentes.RubikRegular(12);
            textBoxNombreTarea.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxNombreTarea.Location = new Point(this.panelFormulario.Width / 3, 130);
            textBoxNombreTarea.Height = 25;
            textBoxNombreTarea.KeyPress += (s, i) => {
                if (i.KeyChar == (char)Keys.Enter)
                {
                    i.Handled = true;
                }
            };

            labelDescripcionTarea.Font = Fuentes.RubikBold(12);
            labelDescripcionTarea.Location = new Point(this.panelFormulario.Width / 6, 175);
            labelDescripcionTarea.ForeColor = Color.FromArgb(92, 135, 153);

            textBoxDescripcionTarea.Font = Fuentes.RubikRegular(12);
            textBoxDescripcionTarea.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxDescripcionTarea.Location = new Point(this.panelFormulario.Width / 3, 175);
            textBoxDescripcionTarea.Multiline = true;
            textBoxDescripcionTarea.Height = 85;

            labelFechaInicio.Font = Fuentes.RubikBold(12);
            labelFechaInicio.Location = new Point(this.panelFormulario.Width / 6, 285);
            labelFechaInicio.ForeColor = Color.FromArgb(92, 135, 153);
            labelFechaInicio.BringToFront();
            dateTimePickerInicio.Font = Fuentes.RubikRegular(12);
            dateTimePickerInicio.Location = new Point(this.panelFormulario.Width / 3, 285);


            labelFechaFin.Font = Fuentes.RubikBold(12);
            labelFechaFin.Location = new Point(this.panelFormulario.Width / 6, 325);
            labelFechaFin.ForeColor = Color.FromArgb(92, 135, 153);
            dateTimePickerFin.Font = Fuentes.RubikRegular(12);
            dateTimePickerFin.Location = new Point(this.panelFormulario.Width / 3, 325);

            labelEstado.Font = Fuentes.RubikBold(12);
            labelEstado.Location = new Point(this.panelFormulario.Width / 6, 375);
            labelEstado.ForeColor = Color.FromArgb(92, 135, 153);
            comboBoxEstado.Font = Fuentes.RubikRegular(12);
            comboBoxEstado.Location = new Point(this.panelFormulario.Width / 3, 375);


            labelUsuarios.Font = Fuentes.RubikBold(20);
            labelUsuarios.Location = new Point(this.panelFormulario.Width / 3, 425);
            labelUsuarios.ForeColor = Color.FromArgb(92, 135, 153);
            checkedListBoxUsuarios.Font = Fuentes.RubikRegular(12);
            checkedListBoxUsuarios.Location = new Point(this.panelFormulario.Width / 4, 470);


            labelHoursDedicated.Font = Fuentes.RubikBold(12);
            labelHoursDedicated.Location = new Point(this.panelFormulario.Width / 6, 590);
            labelHoursDedicated.ForeColor = Color.FromArgb(92, 135, 153);
            mtbHoursDedicated.Font = Fuentes.RubikRegular(12);
            mtbHoursDedicated.Location = new Point(this.panelFormulario.Width / 3, 590);

            int spacing = 20;
            int totalWidth = buttonCrear.Width + buttonCancelar.Width + spacing;

            int startX = (panelFormulario.Width - totalWidth) / 3;

            buttonCrear.Font = Fuentes.RubikBold(15);
            buttonCrear.Size = new Size(210, 50);
            buttonCrear.Location = new Point(startX, 630);
            buttonCrear.ForeColor = Color.FromArgb(252, 250, 249);
            buttonCrear.BackColor = Color.FromArgb(204, 163, 193);

            buttonCancelar.Font = Fuentes.RubikBold(15);
            buttonCancelar.Size = new Size(210, 50);
            buttonCancelar.Location = new Point(startX + buttonCrear.Width + spacing, 630);
            buttonCancelar.ForeColor = Color.FromArgb(252, 250, 249);
            buttonCancelar.BackColor = Color.FromArgb(211, 145, 109);

            string rutaJson = Path.Combine(Application.StartupPath, "Json", "users.json");
            usuariosRegistrados = CargarUsuariosDesdeJson(rutaJson);

            checkedListBoxUsuarios.Items.Clear();

            foreach (var idDisponible in usuariosDisponibles)
            {
                var user = usuariosRegistrados.FirstOrDefault(u => u.id == idDisponible);

                if (user != null)
                {
                    checkedListBoxUsuarios.Items.Add(user.username);
                }
            }

            comboBoxEstado.Items.Clear();
            comboBoxEstado.Items.AddRange(Enum.GetNames(typeof(TaskState)));
            comboBoxEstado.SelectedIndex = 0;

            if (TareaEnEdicion != null)
            {
                textBoxNombreTarea.Text = TareaEnEdicion.name;
                textBoxDescripcionTarea.Text = TareaEnEdicion.description;
                mtbHoursDedicated.Text = TareaEnEdicion.hoursDedicated.ToString(@"hh\:mm");

                dateTimePickerInicio.Value = TareaEnEdicion.startDate.Date;
                dateTimePickerFin.Value = TareaEnEdicion.deadline.Date;

                comboBoxEstado.SelectedItem = TareaEnEdicion.state.ToString();

                foreach (string idAsignado in TareaEnEdicion.users)
                {
                    var usuario = usuariosRegistrados.FirstOrDefault(u => u.id == idAsignado);

                    if (usuario != null)
                    {
                        int index = checkedListBoxUsuarios.Items.IndexOf(usuario.username);
                        if (index >= 0)
                        {
                            checkedListBoxUsuarios.SetItemChecked(index, true);
                        }
                    }
                }
            }

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            if(!TimeSpan.TryParseExact(mtbHoursDedicated.Text, @"hh\:mm",
                System.Globalization.CultureInfo.InvariantCulture, out TimeSpan horasDedicadas))
            {
                MessageBox.Show("Por favor, introduce las horas dedicadas correctamente.",
                     "Error de formato (00:00)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbHoursDedicated.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombreTarea.Text))
            {
                MessageBox.Show("Debes ingresar un nombre para la tarea.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescripcionTarea.Text))
            {
                MessageBox.Show("Debes ingresar una descripción para la tarea.");
                return;
            }

            List<string> usuariosSeleccionados = checkedListBoxUsuarios.CheckedItems.Cast<string>().ToList();

            if (usuariosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un usuario para la tarea.");
                return;
            }

            List<string> idSeleccionados = new List<string>();
            foreach (string nombre in usuariosSeleccionados)
            {
                var usuario = usuariosRegistrados.FirstOrDefault(u => u.username == nombre);
                if (usuario != null)
                {
                    idSeleccionados.Add(usuario.id);
                }
            }

            if (idSeleccionados.Count == 0)
            {
                MessageBox.Show("Error al mapear usuarios a IDs. Revisar archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime start = dateTimePickerInicio.Value.Date;
            DateTime end = dateTimePickerFin.Value.Date;

            if (end < start)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                return;
            }

            TaskState estadoSeleccionado = (TaskState)Enum.Parse(typeof(TaskState),
                comboBoxEstado.SelectedItem.ToString());

            if (TareaEnEdicion != null) 
            { 
                TareaCreada = TareaEnEdicion;
                TareaCreada.name = textBoxNombreTarea.Text;
                TareaCreada.description = textBoxDescripcionTarea.Text;
                TareaCreada.users = idSeleccionados;
                TareaCreada.hoursDedicated = horasDedicadas;
                TareaCreada.startDate = start;
                TareaCreada.deadline = end;
                TareaCreada.state = estadoSeleccionado;
            } 
            else
            {
                TareaCreada = new Task
                {
                    id = Guid.NewGuid().ToString(),
                    name = textBoxNombreTarea.Text,
                    description = textBoxDescripcionTarea.Text,
                    users = idSeleccionados,
                    hoursDedicated = horasDedicadas,
                    startDate = start,
                    deadline = end,
                    state = estadoSeleccionado,
                    subTasks = new List<SubTasks>()
                };

            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public List<InfoUser> CargarUsuariosDesdeJson(string ruta)
        {
            if (!File.Exists(ruta))
                return new List<InfoUser>();

            string json = File.ReadAllText(ruta);
            return JsonConvert.DeserializeObject<List<InfoUser>>(json);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void mtbHoursDedicated_Validating(object sender, CancelEventArgs e)
        {
            string horaCompleta = mtbHoursDedicated.Text;

            if (DateTime.TryParseExact(horaCompleta, "HH:mm",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime resultado))
            {
                int hour = resultado.Hour;
                int minute = resultado.Minute;

                string[] partes = horaCompleta.Split(':');
                int h = int.Parse(partes[0]);
                int m = int.Parse(partes[1]);

                if (m >= 60)
                {
                    e.Cancel = true;
                    MessageBox.Show("Los minutos deben ser menores a 60.", "Error de Formato",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                e.Cancel = true;
                MessageBox.Show("El formato de hora no es válido o está incompleto (ejemplo: 23:59).",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
