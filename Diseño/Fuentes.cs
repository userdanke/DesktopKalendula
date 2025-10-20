using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopKalendula.Diseño
{
    public static class Fuentes
    {
        private static PrivateFontCollection fuentes = new PrivateFontCollection();

        public static void Cargar(string rutaArchivo)
        {
            fuentes.AddFontFile(rutaArchivo);
        }

        public static Font Obtener(float tamaño, FontStyle estilo = FontStyle.Regular)
        {
            return new Font(fuentes.Families[0], tamaño, estilo);
        }

        public static Font Obtener(int indice, float tamaño, FontStyle estilo = FontStyle.Regular)
        {
            return new Font(fuentes.Families[indice], tamaño, estilo);
        }
    }
}
