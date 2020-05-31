using System;

namespace Iterador
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenedora datos = new Contenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
