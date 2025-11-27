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
        private ListView listaUsuarios;
        private List<InfoUser> usuariosRegistrados;
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

            TareaCreada = new Task
            {
                Id = Guid.NewGuid().ToString(),
                name = textBoxNombreTarea.Text,
                description = textBoxDescripcionTarea.Text,
                users = usuariosSeleccionados,
                hoursDedicated = (double)numericUpDownHoursDedicated.Value,
                startDate = dateTimePickerInicio.Value,
                deadline = dateTimePickerFin.Value,
                state = comboBoxEstado.SelectedItem.ToString(),
                subTasks = new List<SubTasks>()
            };

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
