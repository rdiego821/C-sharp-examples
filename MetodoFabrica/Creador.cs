using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoFabrica
{
    class Creador
    {
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;

            if (pDinero > 1000000)
                temp = new Avion();
            else if (pDinero > 2000000)
                temp = new Auto();
            else
                temp = new Bici();

            return temp;
            
        }
    }
}
