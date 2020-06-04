using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia
{
    class Resta : IOperacion
    {
        public double Operacion(double a, double b)
        {
            return a - b;
        }
    }
}
