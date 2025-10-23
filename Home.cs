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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Logo.Location = new Point(900, 60);
            textBoxBuscar.Location = new Point(800, 110);
            textBoxBuscar.Height = textBoxBuscar.Font.Height + 10;
            textBoxBuscar.Font = Fuentes.RubikRegular(15);
            textBoxBuscar.Multiline = true;
            placeHolder(textBoxBuscar, "Buscar...");

        }

        private void placeHolder(TextBox tb, string placeHolder)
        {
            tb.Text = placeHolder;
            tb.ForeColor = Color.FromArgb(148,172,192);

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeHolder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.FromArgb(61, 23, 0);
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeHolder;
                    tb.ForeColor = Color.FromArgb(148, 172, 192);
                }
            };

            tb.TextChanged += (s, e) =>
            {
                if (tb.Text != placeHolder)
                {
                    tb.ForeColor = Color.FromArgb(148, 172, 192);
                }
            };

        }

    }
}
