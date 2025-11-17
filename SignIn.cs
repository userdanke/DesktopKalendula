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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopKalendula
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            ImgSignIn.Location = new Point(
                (this.ClientSize.Width - ImgSignIn.Width) / 2,
                100);

            panelSignIn.Location = new Point(
                (this.ClientSize.Width - panelSignIn.Width) / 2, 410);
            panelSignIn.Size = new Size(700, 600);

            btnSignIn.Location = new Point(230,300);
            btnSignIn.Size = new Size(250, 60);
            btnSignIn.Font = Fuentes.RubikBold(25);
            btnSignIn.ForeColor = Color.FromArgb(252, 250, 249);

            labelEmail.Font = Fuentes.RubikRegular(20);
            labelEmail.ForeColor = Color.FromArgb(211, 145, 109);
            labelEmail.Location = new Point(50, 40);

            textBoxEmail.Font = Fuentes.RubikRegular(15);
            textBoxEmail.Location = new Point(58, 80);
            textBoxEmail.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxEmail.Multiline = true;
            textBoxEmail.Height = 35;
            textBoxEmail.KeyPress += (s, i) => {
                if (i.KeyChar == (char)Keys.Enter)
                {
                    i.Handled = true; 
                }
            };
            textBoxEmail.Padding = new Padding(50, 12, 50, 0);

            labelPassword.Font = Fuentes.RubikRegular(20);
            labelPassword.ForeColor = Color.FromArgb(211, 145, 109);
            labelPassword.Location = new Point(50, 140);

            textBoxPassword.Font = Fuentes.RubikRegular(15);
            textBoxPassword.Location = new Point(58, 180);
            textBoxPassword.ForeColor = Color.FromArgb(61, 23, 0);
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Multiline = true;
            textBoxPassword.Height = 35;
            textBoxPassword.TextAlign = HorizontalAlignment.Left;
            textBoxPassword.KeyPress += (s, i) => {
                if (i.KeyChar == (char)Keys.Enter)
                {
                    i.Handled = true;
                }
            };
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
