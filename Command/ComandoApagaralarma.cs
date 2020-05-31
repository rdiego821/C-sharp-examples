using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoApagaralarma : IComando
    {
        Automovil auto;

        public ComandoApagaralarma(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            auto.QuitarAlarma();
        }
    }
}
