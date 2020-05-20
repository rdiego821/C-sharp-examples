using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBuilder
    {
        void ConstruyeMotor();
        void ConstruyeCarroceria();
        void ConstruyeLlantas();
    }
}
