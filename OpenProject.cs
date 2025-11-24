using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public OpenProject()
        {
            InitializeComponent();
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 900);

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
    }
}
