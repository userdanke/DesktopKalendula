using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopKalendula
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Color color { get; set; }


        public Tarea(string nombre, DateTime FechaInicio, DateTime FechaFin, Color color)
        {
            this.Nombre = nombre;
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
            this.color = color;

        }

        public bool estaActivaEn(DateTime fecha)
        {
            return fecha.Date >= FechaInicio.Date && fecha.Date <= FechaFin.Date;
        }
    }

}
