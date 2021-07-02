using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Pieza
    {
    public abstract decimal Area();
    public abstract decimal Perimetro();
    }

    public class Cuadrado : Pieza 
    {
        decimal Lado;

        public Cuadrado(decimal lado) 
        { Lado = lado; }

        public override decimal Area()
        {
            return Lado * Lado;
        }

        public override decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}
