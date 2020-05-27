using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    interface IFlyWeight
    {
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenNombre();
    }
}
