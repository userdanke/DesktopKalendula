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
            Fuentes.Cargar(@"C:\Users\CEP-TARDA\Source\Repos\DesktopKalendula\Diseño\Rubik-Italic.ttf");
            InitializeComponent();

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            Label lblCalistoga = new Label();
            lblCalistoga.Text = "Kalendulá";
            lblCalistoga.Font = Fuentes.Calistoga(100);
            lblCalistoga.Location = new Point(50, 50);
            lblCalistoga.AutoSize = true;
            this.Controls.Add(lblCalistoga);
        }

    }

}


