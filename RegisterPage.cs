using DesktopKalendula.Diseño;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

            //// Mostrar la ruta completa
            //string rutaCompleta = Path.GetFullPath("Usuarios.json");
            //MessageBox.Show($"El archivo está en:\n{rutaCompleta}", "Ubicación");

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
                if (i == 3)
                {
                    txt.PasswordChar = '*';
                }
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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please complete all fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = $"{txtFirstName.Text}{txtLastName.Text}";

                string rol = UsuarioManager.ExistenUsuarios() ? "User" : "Manager";

                bool registroExistoso = UsuarioManager.RegistrarUsuario(
                    fullName, txtPassword.Text, txtEmail.Text, rol
                    );

                //MessageBox.Show($"Resultado del registro: {registroExistoso}", "Debug");

                if (registroExistoso)
                {
                    MessageBox.Show($"User successfully registered as {rol}.", "Successful registration", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();

                    SignIn formsign = new SignIn();
                    formsign.Show();
                    this.Hide();
                }
                else { 
                    MessageBox.Show("The email is already registered or there was an error.", "Registration error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void panelrosa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

