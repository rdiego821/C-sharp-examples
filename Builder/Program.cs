using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();

            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);

            Producto auto1 = normal.ObtenProducto();
            //auto1.MostrarAuto();

            Console.WriteLine(auto1);

            Console.WriteLine("------");

            BuilderDeportivo deportivo = new BuilderDeportivo();
            miDirector.Construye(deportivo);

            Producto auto2 = deportivo.ObtenProducto();
            //auto2.MostrarAuto();
            Console.WriteLine(auto2);
        }
    }
}
