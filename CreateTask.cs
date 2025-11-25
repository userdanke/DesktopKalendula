using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopKalendula
{
    public partial class CreateTask : Form
    {
        private List<string> usuariosDisponibles;
        public Task TareaCreada { get; private set; }
        public CreateTask(List<string> users)
        {
            InitializeComponent();
            usuariosDisponibles = users;
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {

            foreach (var email in usuariosDisponibles)
            {
                checkedListBoxUsuarios.Items.Add(email);
            }

            comboBoxEstado.Items.AddRange(new string[] { "Pendiente", "En Progreso", "Completada" });
            comboBoxEstado.SelectedIndex = 0;

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            //// Validar campos obligatorios
            //if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            //{
            //    MessageBox.Show("Debes ingresar un nombre para la tarea.");
            //    return;
            //}

            //List<string> usuariosSeleccionados = checkedListBoxUsuarios.CheckedItems.Cast<string>().ToList();

            //TareaCreada = new Task
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Name = textBoxNombre.Text,
            //    Description = textBoxDescripcion.Text,
            //    Users = usuariosSeleccionados,
            //    HoursDedicated = (double)numericUpDownHoras.Value,
            //    StartDate = dateTimePickerInicio.Value,
            //    Deadline = dateTimePickerFin.Value,
            //    State = comboBoxEstado.SelectedItem.ToString(),
            //    SubTasks = new List<SubTask>()
            //};

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
