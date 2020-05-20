using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstruyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void ConstruyeLlantas()
        {
            auto.ColocarLlantas(new llantas12());
        }

        public void ConstruyeMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
