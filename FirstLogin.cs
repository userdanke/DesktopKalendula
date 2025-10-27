using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;

namespace DesktopKalendula
{
    public partial class FirstLogin : Form
    {
        public FirstLogin()
        {
            InitializeComponent();
            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
        }

        private void FirstLogin_Load(object sender, EventArgs e)
        {
            lblk.Font = Fuentes.Calistoga(100);
            lblk.Left = (this.ClientSize.Width - lblk.Width) / 2;
            lblk.Top = 250;
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(1250,270);




        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
