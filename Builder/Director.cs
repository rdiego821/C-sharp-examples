using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        public void Construye(IBuilder pConstructor)
        {
            pConstructor.ConstruyeMotor();
            pConstructor.ConstruyeCarroceria();
            pConstructor.ConstruyeLlantas();
        }
    }
}
