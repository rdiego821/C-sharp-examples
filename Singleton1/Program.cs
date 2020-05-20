using System;

namespace Singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton uno = Singleton.ObtenerInstancia();
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("------");

            Singleton dos = Singleton.ObtenerInstancia();
            Console.WriteLine(dos);

            Console.WriteLine("-------");

            SingletonClass tres = SingletonClass.SingleInstance;
            Console.WriteLine(tres);
        }
    }
}
