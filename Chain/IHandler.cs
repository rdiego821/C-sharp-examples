using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    interface IHandler
    {
        double CalculaPrecioFinal(int pCantidad, double pPrecio);
    }
}
