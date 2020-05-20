using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IMotor
    {
        string especificaciones();
    }

    class MotorBasico : IMotor
    {
        public string especificaciones()
        {
            return "Motor de 4 cilindros";
        }
    }

    class MotorGrande : IMotor
    {
        public string especificaciones()
        {
            return "Motor de 8 cilindros";
        }
    }
}
