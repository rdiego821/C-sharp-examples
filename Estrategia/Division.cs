using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia
{
    class Division : IOperacion
    {
        public double Operacion(double a, double b)
        {
            return a / b;
        }
    }
}
