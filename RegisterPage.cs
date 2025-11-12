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
            Logo.Location = new Point(505,55);
            panelrosa.Left = (this.ClientSize.Width - panelrosa.Width) / 2;
            panelrosa.Top = 230;
            btnSignUp.Font = Fuentes.RubikBold(18);
            btnSignUp.Top = 470;

            int topActual = 60;

            string[] hints = { "First Name", "Last Name", "Email", "Password", "Confirm Password" };
            int indice = 0;
            

            foreach (Control control in panelrosa.Controls)
            {
                if (control is TextBox tb)
                {
                    TextBox textBox = tb;

                    textBox.Left = (panelrosa.Width - textBox.Width) / 2;
                    textBox.Top = topActual;
                    textBox.Font = Fuentes.RubikRegular(12);
                    textBox.ForeColor = Color.FromArgb(195, 182, 174);

                    string hintText = hints[indice];
                    textBox.Text = hintText;
               

                    textBox.Enter += (s, args) =>
                    {
                        if (textBox.Text == hintText)
                        {
                            textBox.Text = "";
                            textBox.ForeColor = Color.Black;

                            if (indice == 3 || indice == 4)
                                textBox.UseSystemPasswordChar = true;

                        }
                    };

                    textBox.Leave += (s, args) => 
                    { 
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            textBox.Text = hintText;
                            textBox.ForeColor = Color.Gray;

                            if (indice == 3 || indice == 4)
                                textBox.UseSystemPasswordChar = false;

                        }
                    };

                    topActual += control.Height + 20;
                    indice++;
                }
                
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
