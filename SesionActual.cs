using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopKalendula
{
    public static class SesionActual
    {
        public static InfoUser UsuarioActual { get; set; }

        public static bool HaySesionActiva()
        {
            return UsuarioActual != null;
        }

        public static void CerrarSesionYReiniciar()
        {
            UsuarioActual = null;
            Application.Restart();
            Environment.Exit(0);
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
