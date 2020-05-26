using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class Suspension : IComponente
    {
        private IComponente decoramosA;

        public Suspension(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto desempenio \r\n" + decoramosA.ToString();
        }
        public double Costo()
        {
            return decoramosA.Costo() + 63580;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando suspension";
        }
    }
}
