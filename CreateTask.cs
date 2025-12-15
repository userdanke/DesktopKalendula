using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DesktopKalendula
{
    public partial class CreateTask : Form
    {
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

                dateTimePickerInicio.Value = TareaEnEdicion.deadline.Date;
                dateTimePickerFin.Value = TareaEnEdicion.startDate.Date;

                comboBoxEstado.SelectedItem = TareaEnEdicion.state.ToString();

                foreach(string idAsignado in TareaEnEdicion.users)
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
