using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;

namespace DesktopKalendula
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string rutaFuentes = Path.Combine(Application.StartupPath, "Diseño");
            Fuentes.CargarDesdeDirectorio(rutaFuentes);

            Application.Run(new Calendar());
        }
    }
}
    