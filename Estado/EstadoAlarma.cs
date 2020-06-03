using System;
using System.Collections.Generic;
using System.Text;

namespace Estado
{
    class EstadoAlarma : IEstado
    {
        Caldera miCaldera;

        public EstadoAlarma(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }

        public void Trabajar()
        {
            Console.WriteLine("ALARMA! Alta temperatura!");
            miCaldera.Temperatura -= 5;

            if (miCaldera.Temperatura < 90 || miCaldera.Combustible <= 0)
                miCaldera.ColocarEstado(miCaldera.Espera);
        }

        public void CortarFuego()
        {
            Console.WriteLine("No se encuentra prendida");
        }

        public void PonerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible con temperatura alta");
        }

        public void ForzarFuego()
        {
            Console.WriteLine("Aumetara la temperatura");
            miCaldera.Combustible -= 3;
            miCaldera.Temperatura += 10;
        }

        public override string ToString()
        {
            return string.Format("Alarma-> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }
    }
}
