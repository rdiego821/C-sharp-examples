using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete
{
    class Contexto
    {
        private string expresion;
        private int valor;

        public string Expresion { get => expresion; set => expresion = value; }
        public int Valor { get => valor; set => valor = value; }

        public Contexto(string pExpresion)
        {
            expresion = pExpresion;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Se evaluara {0}", expresion);
        }

    }
}
