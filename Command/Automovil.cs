using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Automovil
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha encendido el auto");
        }

        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha apagado el auto");
        }

        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alarma encendida");
        }

        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alarma apagada");
        }
    }
}
