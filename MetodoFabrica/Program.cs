using System;

namespace MetodoFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tienes para tu vehiculo?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            vehiculo = Creador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

            Test.Prueba();
            Test.Prueba2();

        }
    }
}
