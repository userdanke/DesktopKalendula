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

        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(190, 125, 90); } 
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(170, 105, 70); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(170, 105, 70); }
        }


        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(211, 145, 109); }
        }


        public override Color MenuBorder
        {
            get { return Color.FromArgb(170, 105, 70); }
        }
    }
}
