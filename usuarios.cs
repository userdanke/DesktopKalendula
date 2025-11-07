using DesktopKalendula.Diseño;
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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            btnanyadirusuarios.Font = Fuentes.RubikMedium(12);
            btnanyadirusuarios.Location = new Point(1250,150);
            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            Logo.Top = 750;
        }

        private void btnanyadirusuarios_Click(object sender, EventArgs e)
        {
            Panel panelformulario = new Panel();
            panelformulario.Size = new Size(600, 700);
            panelformulario.BackColor = Color.FromArgb(243,221,209);
            panelformulario.Location = new Point(
                (this.ClientSize.Width - panelformulario.Width) / 2,
                (this.ClientSize.Height - panelformulario.Height) /2
                 );

            TextBox txtnombre = new TextBox();
            txtnombre.Text = "Nombre Completo";
            txtnombre.BorderStyle = BorderStyle.None;
            txtnombre.Multiline = true;
            txtnombre.Size = new Size(500, 40);








            panelformulario .Controls.Add(txtnombre);
            this.Controls.Add(panelformulario);
            panelformulario.BringToFront();
        }
    }
}
