using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo
{
    class Persona : IPrototipo
    {
        public string nombre { get; set; }
        public int edad;


        public Persona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, edad);
        }
        public object Clonar()
        {
            Persona clon = new Persona(nombre, edad);
            return clon;
        }
    }
}
