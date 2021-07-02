using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Producto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Producto()
        {
          
        }

        public Producto(Producto pProdi)
        {
            this.id = pProdi.id;
            this.nombre = pProdi.nombre;
        }
    }
}
