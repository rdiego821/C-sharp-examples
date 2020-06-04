using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Estrategia
{
    class Multiplicacion : IOperacion
    {
       
        public double Operacion(double a, double b)
        {
            return a * b;
        }
    }
}
