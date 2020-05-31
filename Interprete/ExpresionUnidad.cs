using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete
{
    class ExpresionUnidad : Expresion
    {
        public override string Unidad()
        {
            return "I";
        }

        public override string Cuatro()
        {
            return "IV";
        }

        public override string Cinco()
        {
            return "V";
        }

        public override string Nueve()
        {
            return "IX";
        }

        public override int Factor()
        {
            return 1;
        }
    }
}
