using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo
{
    class Valores : IPrototipo
    {
        private int m = 1;
        public double sumatoria { get; set; }
        public int M { get => m; set => m = value; }



        public Valores()
        {

        }

        public Valores(int pM)
        {
            M = pM;
            int n = 0;
            for (n = 0; n < 90; n++)
            {
                sumatoria += Math.Sin(n * 0.0175);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m); 
        }
        public object Clonar()
        {
            Valores clon = new Valores();
            clon.M = m;
            clon.sumatoria = sumatoria;
            return clon;
        }
    }
}
