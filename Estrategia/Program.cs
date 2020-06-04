using System;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";

            IOperacion miOperacion = new Suma();

            while (opcion != "5")
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicacion, 4-Division,, 5-Salir");
                opcion = Console.ReadLine();
                if (opcion == "5")
                    break;

                Console.WriteLine("Dame el valor de a");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Dame el valor de b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                if (opcion == "1")
                    miOperacion = new Suma();

                if (opcion == "2")
                    miOperacion = new Resta();

                if (opcion == "3")
                    miOperacion = new Multiplicacion();

                if (opcion == "4")
                    miOperacion = new Division();

                r = miOperacion.Operacion(x, y);

                Console.WriteLine("El resultado es {0}", r);



            }
        }
    }
}
