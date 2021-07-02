using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Trabajador : Persona
    {
        // Campo de cada objeto Trabajador que almacena cuánto gana
        public int Sueldo;
        public DateTime fechaNacimiento;

        public Trabajador(string nombre, int edad, string nif, int sueldo, DateTime _fechaNacimiento)
            : base(nombre, edad, nif) 
        {
            Sueldo = sueldo;
            fechaNacimiento = _fechaNacimiento;
        }

    }
}
