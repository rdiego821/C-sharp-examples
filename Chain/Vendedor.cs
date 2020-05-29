using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    class Vendedor : IHandler
    {
        private IHandler siguiente = null;

        public Vendedor(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el vendedor");

            double total = pCantidad * pPrecio;

            if (pCantidad > 20 || total > 20000)
            {
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            }
            else
            {
                if (pCantidad > 10)
                    total *= 0.95;
            }

            return total;
        }
    }
}
