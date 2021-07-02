using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Pais
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Pais(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Pais()
        {

        }

        public Pais(Pais pProdi)
        {
            this.id = pProdi.id;
            this.nombre = pProdi.nombre;
        }
    }
}
