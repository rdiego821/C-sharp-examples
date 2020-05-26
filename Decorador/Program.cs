using System;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente miAuto = new Auto("2018", "4 puertas", 200000);

            Console.WriteLine(miAuto);

            ((Auto)miAuto).Puertas(true);

            Console.WriteLine("-----");

            miAuto = new SistemaSonido(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-------");

            miAuto = new Nitrogeno(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-------");

            ((Nitrogeno)miAuto).UsaN();

            Console.WriteLine("-----");

            miAuto = new Suspension(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-----");

        }
    }
}
