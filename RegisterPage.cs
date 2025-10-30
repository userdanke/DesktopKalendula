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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            lblsignup.Font = Fuentes.Calistoga(50);
            lblsignup.Left = (this.ClientSize.Width - lblsignup.Width) / 2;
            lblsignup.Top = 80;
            Logo.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Logo.Location = new Point(690,55);
        }
    }
}
