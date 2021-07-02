﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Persona
    {
        // Campo de cada objeto Persona que almacena su nombre
        public string Nombre;
        // Campo de cada objeto Persona que almacena su edad
        public int Edad;
        // Campo de cada objeto Persona que almacena su NIF

        public string NIF;

       public void Cumpleaños()   // Incrementa en uno de edad del objeto Persona
        {
            Edad++;
        }

        // Constructor de Persona
        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }
    }
}
