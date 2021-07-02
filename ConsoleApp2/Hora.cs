using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Hora
    {
        public static DateTime fecha = DateTime.Now;
        public static DateTime VerAlFuturo() 
        {
            return fecha.AddMinutes(5);
        }
    }

    public class ObtenerHora 
    {
        public DateTime ObtenerFechaYHora() { return Hora.VerAlFuturo(); }
    }
}
