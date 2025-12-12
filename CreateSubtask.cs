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
using Newtonsoft.Json;

namespace DesktopKalendula
{
    public partial class CreateSubtask : Form
    {
        public SubTasks SubTareaCreada { get; private set; }
        public SubTasks SubTareaEnEdicion;

        public CreateSubtask(List<string> users)
        {
            InitializeComponent();
        }

        private void CreateSubtask_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Clear();
            comboBoxEstado.Items.AddRange(Enum.GetNames(typeof(SubtaskState)));
            comboBoxEstado.SelectedIndex = 0;


            if (SubTareaEnEdicion != null)
            {
                textBoxNombreSubtarea.Text = SubTareaEnEdicion.name;
                textBoxDescripcionSubtarea.Text = SubTareaEnEdicion.description;
                mtbHoursDedicated.Text = SubTareaEnEdicion.hoursDedicated.ToString(@"hh\:mm");
                if (SubTareaEnEdicion.startDate > DateTimePicker.MinimumDateTime)
                    dateTimePickerInicio.Value = SubTareaEnEdicion.startDate;
                else
                    dateTimePickerInicio.Value = DateTime.Now.Date;

                if (SubTareaEnEdicion.deadline > DateTimePicker.MinimumDateTime)
                    dateTimePickerFin.Value = SubTareaEnEdicion.deadline.Date;
                else
                    dateTimePickerFin.Value = DateTime.Now.AddDays(1);
                comboBoxEstado.SelectedItem = SubTareaEnEdicion.state.ToString();
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            if (!TimeSpan.TryParseExact(mtbHoursDedicated.Text, @"hh\:mm",
                System.Globalization.CultureInfo.InvariantCulture, out TimeSpan horasDedicadas))
            {
                MessageBox.Show("Por favor, introduce las horas dedicadas correctamente.",
                    "Error de formato (00:00)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbHoursDedicated.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombreSubtarea.Text))
            {
                MessageBox.Show("Debes ingresar un nombre para la Subtarea.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescripcionSubtarea.Text))
            {
                MessageBox.Show("Debes ingresar una descripción para la Subtarea.");
                return;
            }

            DateTime start = dateTimePickerInicio.Value.Date;
            DateTime end = dateTimePickerFin.Value.Date;

            if (end < start)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                return;
            }

            SubtaskState estadoSeleccionado = (SubtaskState)Enum.Parse(typeof(SubtaskState),
                comboBoxEstado.SelectedItem.ToString());

            if (SubTareaEnEdicion != null)
            {
                SubTareaCreada = SubTareaEnEdicion;
                SubTareaCreada.name = textBoxNombreSubtarea.Text;
                SubTareaCreada.description = textBoxDescripcionSubtarea.Text;
                SubTareaCreada.hoursDedicated = horasDedicadas;
                SubTareaCreada.startDate = start;
                SubTareaCreada.deadline = end;
                SubTareaCreada.state = estadoSeleccionado;
            }
            else
            {
                SubTareaCreada = new SubTasks
                {
                    id = Guid.NewGuid().ToString(),
                    name = textBoxNombreSubtarea.Text,
                    description = textBoxDescripcionSubtarea.Text,
                    hoursDedicated = horasDedicadas,
                    startDate = start,
                    deadline = end,
                    state = estadoSeleccionado,
                };

            }

            this.DialogResult = DialogResult.OK;
            this.Close();
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
