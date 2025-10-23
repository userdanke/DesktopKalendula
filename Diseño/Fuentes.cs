using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopKalendula.Diseño
{
    public static class Fuentes
    {
        private static PrivateFontCollection fuentes = new PrivateFontCollection();

        // Cargar fuente desde archivo
        public static void Cargar(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                fuentes.AddFontFile(rutaArchivo);
            }
        }

        // Cargar todas las fuentes de una carpeta
        public static void CargarDesdeDirectorio(string rutaCarpeta)
        {
            if (!Directory.Exists(rutaCarpeta))
            {
                MessageBox.Show($"No se encontró la carpeta de fuentes: {rutaCarpeta}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] archivos = Directory.GetFiles(rutaCarpeta, "*.ttf");

            if (archivos.Length == 0)
            {
                MessageBox.Show($"No se encontraron archivos .ttf en: {rutaCarpeta}",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (string archivo in archivos)
            {
                Cargar(archivo);
            }
        }

        // Obtener fuente por nombre
        public static Font Obtener(string nombreFamilia, float tamaño, FontStyle estilo = FontStyle.Regular)
        {
            foreach (var familia in fuentes.Families)
            {
                if (familia.Name.Contains(nombreFamilia))
                {
                    return new Font(familia, tamaño, estilo);
                }
            }
            // Si no encuentra la fuente, devuelve una por defecto
            return new Font("Arial", tamaño, estilo);
        }

        // Atajos para las fuentes Rubik
        public static Font RubikBold(float tamaño) => Obtener("Rubik", tamaño, FontStyle.Bold);
        public static Font RubikBoldItalic(float tamaño) => Obtener("Rubik", tamaño, FontStyle.Bold | FontStyle.Italic);
        public static Font RubikRegular(float tamaño) => Obtener("Rubik", tamaño, FontStyle.Regular);
        public static Font RubikItalic(float tamaño) => Obtener("Rubik", tamaño, FontStyle.Italic);
        public static Font RubikLight(float tamaño) => Obtener("Rubik Light", tamaño);
        public static Font RubikLightItalic(float tamaño) => Obtener("Rubik Light", tamaño, FontStyle.Italic);
        public static Font RubikMedium(float tamaño) => Obtener("Rubik Medium", tamaño);
        public static Font RubikMediumItalic(float tamaño) => Obtener("Rubik Medium", tamaño, FontStyle.Italic);
        public static Font RubikSemiBold(float tamaño) => Obtener("Rubik SemiBold", tamaño);
        public static Font RubikSemiBoldItalic(float tamaño) => Obtener("Rubik SemiBold", tamaño, FontStyle.Italic);
        public static Font RubikExtraBold(float tamaño) => Obtener("Rubik ExtraBold", tamaño);
        public static Font RubikExtraBoldItalic(float tamaño) => Obtener("Rubik ExtraBold", tamaño, FontStyle.Italic);
        public static Font RubikBlack(float tamaño) => Obtener("Rubik Black", tamaño);
        public static Font RubikBlackItalic(float tamaño) => Obtener("Rubik Black", tamaño, FontStyle.Italic);
        public static Font Calistoga(float tamaño) => Obtener("Calistoga", tamaño, FontStyle.Regular);
    }
}
