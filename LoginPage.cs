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
            pictureBoxLogo.Location = new Point(
                (this.ClientSize.Width - pictureBoxLogo.Width) / 2,
                (this.ClientSize.Height - pictureBoxLogo.Height) / 2 );

            buttonLogin.Font = Fuentes.RubikBold(40);
            buttonLogin.BackColor = Color.FromArgb(204, 163, 193);
            buttonLogin.ForeColor = Color.FromArgb(252, 250, 249);
            buttonLogin.Location = new Point(770, 750);
            buttonLogin.Size = new Size(350, 100);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
        }
    }

}


