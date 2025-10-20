using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopKalendula
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            Panel barraColores = new Panel();
            barraColores.Dock = DockStyle.Top;
            barraColores.Height = 40;
            barraColores.Paint += BarraColores_Paint;
            this.Controls.Add(barraColores);

            Button btnCerrar = new Button();
            btnCerrar.Text = "X";
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.Location = new Point(barraColores.Width - 25, 5);
            btnCerrar.Click += (s, e) => this.Close();
            barraColores.Controls.Add(btnCerrar);

            Button btnMinimizar = new Button();
            btnMinimizar.Text = "-";
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.Location = new Point(barraColores.Width - 85, 5);
            btnMinimizar.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            barraColores.Controls.Add(btnMinimizar);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarraColores_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int ancho = panel.Width / 4; 

            Color[] colores = { Color.FromArgb(211,145,109), Color.FromArgb(229, 122, 122), Color.FromArgb(204, 163, 193), Color.FromArgb(228, 235, 241) };

            for (int i = 0; i < 4; i++)
            {
                Rectangle rect = new Rectangle(i * ancho, 0, ancho, panel.Height);
                using (Brush b = new SolidBrush(colores[i]))
                {
                    e.Graphics.FillRectangle(b, rect);
                }
            }
        }
    }

}


