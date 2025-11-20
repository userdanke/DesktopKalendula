using DesktopKalendula.Diseño;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //if (UsuarioManager.ExisteMananger())
            //{
            //    Application.Run(new SignIn());

            //}
            //else
            //{
            //    Application.Run(new FirstLogin());
            //}

            Application.Run(new Home());


        }
    }
}
    