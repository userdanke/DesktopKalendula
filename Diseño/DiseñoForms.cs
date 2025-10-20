using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;

namespace DesktopKalendula
{
    public class DiseñoForms : Panel
    {

        private Button btnCerrar;
        private Button btnMinimizar;
        private Color[] colores = {
        Color.FromArgb(211, 145, 109),
        Color.FromArgb(229, 122, 122),
        Color.FromArgb(204, 163, 193),
        Color.FromArgb(228, 235, 241) };

        public DiseñoForms()
        {
 
            this.Dock = DockStyle.Top;
            this.Height = 40;
            this.Paint += BarraColores_Paint; ;

            btnCerrar = new Button();
            btnCerrar.Text = "✕";
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.ForeColor = Color.FromArgb(61, 23, 0);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.Click += (s, e) => Application.Exit(); 

            btnMinimizar = new Button();
            btnMinimizar.Text = "⎯";
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.ForeColor = Color.FromArgb(61, 23, 0);
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.Click += (s, e) => this.FindForm().WindowState = FormWindowState.Minimized;

            this.Controls.Add(btnCerrar);
            this.Controls.Add(btnMinimizar);

            this.Resize += DiseñoForms_Resize;
        }

        private void DiseñoForms_Resize(object sender, EventArgs e)
        {

            btnCerrar.Location = new Point(this.Width - btnCerrar.Width - 5, 5);
            btnMinimizar.Location = new Point(this.Width - btnCerrar.Width - btnMinimizar.Width - 10, 5);
        }

        private void BarraColores_Paint(object sender, PaintEventArgs e)
        {
            int ancho = this.Width / colores.Length;
            for (int i = 0; i < colores.Length; i++)
            {
                Rectangle rect = new Rectangle(i * ancho, 0, ancho, this.Height);
                using (Brush b = new SolidBrush(colores[i]))
                {
                    e.Graphics.FillRectangle(b, rect);
                }
            }
        }

    }
}
