using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class SistemaSonido : IComponente
    {
        private IComponente decoramosA;

        public SistemaSonido(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + decoramosA.ToString();
        }
        public double Costo()
        {
            return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Enciendo el radio";
        }
    }
}
