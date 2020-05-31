using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Interprete
{
    abstract class Expresion
    {
        public void Interpretar(Contexto pContexto)
        {
            if (pContexto.Expresion.Length == 0)
                return;

            if (pContexto.Expresion.StartsWith(Nueve()))
            {
                pContexto.Valor += (9 * Factor());

                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }
            else if (pContexto.Expresion.StartsWith(Cuatro()))
            {
                pContexto.Valor += (4 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }

            else if (pContexto.Expresion.StartsWith(Cinco()))
            {
                pContexto.Valor += (5 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }

            while (pContexto.Expresion.StartsWith(Unidad()))
            {
                pContexto.Valor += (1 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }
        }

        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor();


    }
}
