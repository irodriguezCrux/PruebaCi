using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Romano
    {
        public string letra { get; set; }
        public int numero { get; set; }

        public Romano(string letra, int numero)
        {
            this.letra = letra;
            this.numero = numero;
        }
        public Romano(Romano pRoma)
        {
            this.letra = pRoma.letra;
            this.numero = pRoma.numero;
        }

        public Romano()
        {
        }
    }
}
