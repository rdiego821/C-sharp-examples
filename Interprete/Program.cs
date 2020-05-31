using System;
using System.Collections.Generic;

namespace Interprete
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresionEvaluar = "MCMXCIV";
            Contexto contexto = new Contexto(expresionEvaluar);

            List<Expresion> Arbol = new List<Expresion>();
            Arbol.Add(new ExpresionMiles());
            Arbol.Add(new ExpresionCientos());
            Arbol.Add(new ExpresionDecenas());
            Arbol.Add(new ExpresionUnidad());

            foreach (Expresion exp in Arbol)
            {
                exp.Interpretar(contexto);
            }

            Console.WriteLine("El numero romano {0} es {1} en decimal", expresionEvaluar, contexto.Valor);

        }
    }
}
