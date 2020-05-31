using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoPrenderAlarma : IComando
    {
        Automovil auto;

        public ComandoPrenderAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            auto.ColocarAlarma();
        }
    }
}
