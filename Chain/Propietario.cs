using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    class Propietario : IHandler
    {
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el propietario");
            double total = 0;

            total = pCantidad * pPrecio * 0.85;

            return total;
        }
    }
}
