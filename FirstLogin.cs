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
            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            Logo.Top = 280;
            btnsignup.Left = (this.ClientSize.Width - btnsignup.Width) / 2;
            btnsignup.Top = 570;
            btnsignup.Font = Fuentes.RubikBold(20);
            btnsignin.Left = (this.ClientSize.Width - btnsignin.Width) / 2;
            btnsignin.Top = 640;
            btnsignin.Font = Fuentes.RubikBold(20);
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
