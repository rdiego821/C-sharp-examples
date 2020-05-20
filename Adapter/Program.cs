using System;
using System.Threading.Tasks.Dataflow;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            ITarget calcu = new Calcu();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado es {0}", resultado);

            Console.WriteLine("-----");

            calcu = new Adaptador();

            resultado = calcu.Sumar(5, 6);
            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
