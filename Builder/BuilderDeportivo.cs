using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderDeportivo : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstruyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public void ConstruyeLlantas()
        {
            auto.ColocarLlantas(new llantasSuper());
        }

        public void ConstruyeMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
