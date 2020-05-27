using System;
using Subsistemas;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----");

        }
    }
}
