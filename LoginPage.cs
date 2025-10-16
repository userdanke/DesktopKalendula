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
            barraColores.Dock = DockStyle.Top; // Se mantiene arriba
            barraColores.Height = 40; // Altura de la barra
            barraColores.Paint += BarraColores_Paint; // Evento para dibujar colores
            this.Controls.Add(barraColores);
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
            int ancho = panel.Width / 4; // Dividimos en 4 partes

            // Colores
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


