using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoFabrica
{
    class Auto : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Oprime el pedal del acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Introduce la llave y girala");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el pedal del freno");
        }

        public void Girar()
        {
            Console.WriteLine("Toma el volante y giralo");
        }
    }
}
