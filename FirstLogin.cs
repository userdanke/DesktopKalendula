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
            lblk.Font = Fuentes.Calistoga(140);
            lblk.Left = (this.ClientSize.Width - lblk.Width) / 2;
            lblk.Top = 250;
            lblk.BringToFront();
            lblk.BackColor = Color.Transparent;
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(1360,300);
            btnsignup.Left = (this.ClientSize.Width - btnsignup.Width) / 2;
            btnsignup.Top = 570;
            btnsignup.Font = Fuentes.RubikBold(20);
            btnsignin.Left = (this.ClientSize.Width - btnsignin.Width) / 2;
            btnsignin.Top = 630;
            btnsignin.Font = Fuentes.RubikBold(20);
            acento.Location = new Point(1305, 320);
            acento.BringToFront();





        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblk_Click(object sender, EventArgs e)
        {

        }
    }
}
