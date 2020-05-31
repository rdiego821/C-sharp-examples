using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil miAuto = new Automovil();
            ControlRemoto control = new ControlRemoto(miAuto);

            string opcion;

            do
            {
                Console.WriteLine("1-encender, 2-apagar, 3-prender alarma, 4-apagar alarma, 5-salir");

                opcion = Console.ReadLine();
                if (opcion == "1")
                    control.Boton(0);
                if (opcion == "2")
                    control.Boton(1);
                if (opcion == "3")
                    control.Boton(2);
                if (opcion == "4")
                    control.Boton(3);
                
            } while (opcion != "5");
        }
    }
}
