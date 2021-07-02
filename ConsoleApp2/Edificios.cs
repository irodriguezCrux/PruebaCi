using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Edificios
    {
        public string name { get; set; }

        public List<Inquilinos> Inquilinos = new List<Inquilinos>();

        public Edificios() { }
        public Edificios(Edificios pInq)
        {
            name = pInq.name;
            Inquilinos = pInq.Inquilinos;
        }
        public Edificios(string pNombre, List<Inquilinos> pNumeroLocal)
        {
            name = pNombre;
            Inquilinos = pNumeroLocal;
        }
    }

    public class Inquilinos
    {
        public string nombre { get; set; }
        public int numeroLocal { get; set; }

        public Inquilinos() { }
        public Inquilinos(Inquilinos pInq) 
        {
            nombre = pInq.nombre;
            numeroLocal = pInq.numeroLocal;
        }
        public Inquilinos(string pNombre, int pNumeroLocal)
        {
            nombre = pNombre;
            numeroLocal = pNumeroLocal;
        }
    }
}
