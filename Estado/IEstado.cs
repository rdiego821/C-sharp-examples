using System;
using System.Collections.Generic;
using System.Text;

namespace Estado
{
    interface IEstado
    {
        void Trabajar();
        void CortarFuego();
        void PonerCombustible();
        void ForzarFuego();
    }
}
