using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopKalendula.Diseño
{
    public class MenuColorTable : ProfessionalColorTable
    {
        // Color cuando pasas el mouse por encima
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(190, 125, 90); } // Un tono más oscuro de tu color
        }

        // Color cuando haces clic
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(170, 105, 70); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(170, 105, 70); }
        }

        // Fondo del dropdown
        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(211, 145, 109); }
        }

        // Borde del dropdown
        public override Color MenuBorder
        {
            get { return Color.FromArgb(170, 105, 70); }
        }
    }
}
