using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete
{
    class ExpresionMiles : Expresion
    {
        public override string Unidad()
        {
            return "M";
        }

        public override string Cuatro()
        {
            return " ";
        }

        public override string Cinco()
        {
            return " ";
        }

        public override string Nueve()
        {
            return " ";
        }

        public override int Factor()
        {
            return 1000;
        }
    }
}
