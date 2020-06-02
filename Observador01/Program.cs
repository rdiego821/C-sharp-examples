using System;

namespace Observador01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sujeto miSujeto = new Sujeto();

            Observador a = new Observador("A", miSujeto);
            Observador b = new Observador("B", miSujeto);
            Observador c = new Observador("C", miSujeto);

            for (int n = 0; n < 5; n++)
            {
                miSujeto.Trabajo();
            }

            Console.WriteLine("---- Desuscribir ----");
            miSujeto.Desuscribir(b);

            for (int n = 0; n < 5; n++)
            {
                miSujeto.Trabajo();
            }
        }
    }
}
