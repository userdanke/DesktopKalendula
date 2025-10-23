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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {

            InitializeComponent();

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            label1.Font = Fuentes.Calistoga(54);

        }

    }

}


