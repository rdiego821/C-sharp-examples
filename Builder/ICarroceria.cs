using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ICarroceria
    {
        string caracteristicas();
    }

    class CarroceriaBasica : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de metal";
        }

    }

    class CarroceriaEspecial : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }
}
