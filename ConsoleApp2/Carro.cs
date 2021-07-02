using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IAcelerar
    {
        void acelerar();
    }
    public interface IDetener 
    {
        void detener();
    }

    public interface ICarro : IAcelerar, IDetener 
    {   
    }

    public class Carro : ICarro
    {
        public void acelerar() 
        { 
            Console.WriteLine("Acelerar carro ");
        }
        public void detener()
        {
            Console.WriteLine("Detener carro ");
        }
    }
    public class CarroElectronico : ICarro
    {
        public void acelerar()
        {
            Console.WriteLine("Acelerar carro ");
        }
        public void detener()
        {
            Console.WriteLine("Detener carro ");
        }
    }

}
