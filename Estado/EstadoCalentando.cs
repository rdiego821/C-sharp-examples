using System;
using System.Collections.Generic;
using System.Text;

namespace Estado
{
    class EstadoCalentando : IEstado
    {
        Caldera miCaldera;

        public EstadoCalentando(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }

        public void Trabajar()
        {
            if (miCaldera.Combustible > 0)
            {
                Console.WriteLine("Estamos calentando");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;
            }

            if (miCaldera.Temperatura > 100)
                miCaldera.ColocarEstado(miCaldera.Alarma);
            else if (miCaldera.Temperatura > 80)
                miCaldera.ColocarEstado(miCaldera.Espera);

            if (miCaldera.Combustible <= 0)
                miCaldera.ColocarEstado(miCaldera.Espera);
        }

        public void CortarFuego()
        {
            Console.WriteLine("Cortamos Fuego");
            miCaldera.ColocarEstado(miCaldera.Espera);
        }

        public void PonerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible cuando esta prendida");
        }

        public void ForzarFuego()
        {
            Console.WriteLine("El fuego ya esta prendido");
        }

        public override string ToString()
        {
            return string.Format("Calentando-> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }
    }
}
