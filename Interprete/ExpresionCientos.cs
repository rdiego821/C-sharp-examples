using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete
{
    class ExpresionCientos : Expresion
    {
        public override string Unidad()
        {
            return "C";
        }

        public override string Cuatro()
        {
            return "CD";
        }

        public override string Cinco()
        {
            return "D";
        }

        public override string Nueve()
        {
            return "CM";
        }

        public override int Factor()
        {
            return 100;
        }
    }
}
