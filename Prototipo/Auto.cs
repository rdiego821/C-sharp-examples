using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo
{
    class Auto : IPrototipo
    {
        public string modelo;
        public int costo;

        public Auto(string pModelo, int pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Auto: {0}, {1}", modelo, costo);
        }
        public object Clonar()
        {
            Auto clon = new Auto(modelo, costo);
            return clon;
        }
    }
}
