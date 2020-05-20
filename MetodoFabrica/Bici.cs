using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoFabrica
{
    class Bici : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void Encender()
        {
            Console.WriteLine("Las bicis no necesitan encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el freno trasero primero");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio");
        }
    }
}
