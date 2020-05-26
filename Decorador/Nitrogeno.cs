using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class Nitrogeno : IComponente
    {
        private IComponente decoramosA;

        public Nitrogeno(IComponente pCompomente)
        {
            decoramosA = pCompomente;
        }

        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + decoramosA.ToString();
        }
        public double Costo()
        {
            return decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
