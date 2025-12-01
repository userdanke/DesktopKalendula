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
        public CreateTask(List<string> users, Task tareaEditar = null)
        {
            InitializeComponent();
            usuariosDisponibles = users;
            TareaEnEdicion = tareaEditar;
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {

            foreach (var email in usuariosDisponibles)
            {
                checkedListBoxUsuarios.Items.Add(email);
            }

            comboBoxEstado.Items.AddRange(new string[] { "Pendiente", "En Progreso", "Completada" });
            comboBoxEstado.SelectedIndex = 0;

            if (TareaEnEdicion != null)
            {
                textBoxNombreTarea.Text = TareaEnEdicion.name;
                textBoxDescripcionTarea.Text = TareaEnEdicion.description;
                numericUpDownHoursDedicated.Value = (decimal)TareaEnEdicion.hoursDedicated;
                if (TareaEnEdicion.startDate > DateTimePicker.MinimumDateTime)
                    dateTimePickerInicio.Value = TareaEnEdicion.startDate;
                else
                    dateTimePickerInicio.Value = DateTime.Now;

                if (TareaEnEdicion.deadline > DateTimePicker.MinimumDateTime)
                    dateTimePickerFin.Value = TareaEnEdicion.deadline;
                else
                    dateTimePickerFin.Value = DateTime.Now.AddDays(1);
                comboBoxEstado.SelectedItem = TareaEnEdicion.state;

                foreach(string u in TareaEnEdicion.users)
                {
                    int index = checkedListBoxUsuarios.Items.IndexOf(u);
                    if (index >= 0)
                    {
                        checkedListBoxUsuarios.SetItemChecked(index, true);
                    }
                }
            }

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

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

            DateTime start = dateTimePickerInicio.Value;
            DateTime end = dateTimePickerFin.Value;
            if (end < start)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                return;
            }

            if (TareaEnEdicion != null) 
            { 
                TareaCreada = TareaEnEdicion;
                TareaCreada.name = textBoxNombreTarea.Text;
                TareaCreada.description = textBoxDescripcionTarea.Text;
                TareaCreada.users = usuariosSeleccionados;
                TareaCreada.hoursDedicated = (double)numericUpDownHoursDedicated.Value;
                TareaCreada.startDate = start;
                TareaCreada.deadline = end;
                TareaCreada.state = comboBoxEstado.SelectedItem.ToString();
            } else
            {
                TareaCreada = new Task
                {
                    Id = Guid.NewGuid().ToString(),
                    name = textBoxNombreTarea.Text,
                    description = textBoxDescripcionTarea.Text,
                    users = usuariosSeleccionados,
                    hoursDedicated = (double)numericUpDownHoursDedicated.Value,
                    startDate = start,
                    deadline = end,
                    state = comboBoxEstado.SelectedItem.ToString(),
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
            this.Close();
        }
    }
}
