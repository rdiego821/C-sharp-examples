using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ILlantas
    {
        string informacion();
    }

    class llantas12 : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 14 pulgadas";
        }
    }

    class llantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 18 pulgadas, rines aluminio";
        }
    }

    
}
