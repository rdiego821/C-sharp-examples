using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CalculadoraArray
    {
        public double Suma(int[] pOperandos)
        {
            int n = 0;
            int r = 0;

            for (n = 0; n < pOperandos.Length; n++)
            {
                r += pOperandos[n];
            }

            return r;
        }
    }
}
