// File: RegisterPage.cs
using System;
using System.Drawing;
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
            Logo.Location = new Point(505, 55);

            panelrosa.Left = (this.ClientSize.Width - panelrosa.Width) / 2;
            panelrosa.Top = 230;

            btnSignUp.Font = Fuentes.RubikBold(18);
            btnSignUp.Top = 470;

            int top = 50;

            Label[] labels =
            {
                lblFirstName,
                lblLastName,
                lblEmail,
                lblPassword,
                lblConfirmPassword
            };

            TextBox[] inputs =
            {
                txtFirstName,
                txtLastName,
                txtEmail,
                txtPassword,
                txtConfirmPassword
            };

            for (int i = 0; i < inputs.Length; i++)
            {
                Label label = labels[i];
                TextBox txt = inputs[i];

                // Posicionar textbox
                txt.Left = (panelrosa.Width - txt.Width) / 2;
                txt.Top = top;
                txt.Font = Fuentes.RubikRegular(15);
                txt.ForeColor = Color.Black;

                // Activar PasswordChar solo a los necesarios
                if (i >= 3)
                    txt.UseSystemPasswordChar = true;

                label.Left = txt.Left;                        
                label.Top = txt.Top - label.Height - 15;
                label.Font = Fuentes.RubikRegular(10);
                label.ForeColor = Color.FromArgb(61, 23, 0);
                label.Width = txt.Width;                      
                label.TextAlign = ContentAlignment.MiddleLeft;

                top += txt.Height + 40;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void panelrosa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

