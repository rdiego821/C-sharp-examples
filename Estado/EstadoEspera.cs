using System;
using System.Collections.Generic;
using System.Text;

namespace Estado
{
    class EstadoEspera : IEstado
    {
        Caldera miCaldera;

        public EstadoEspera(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }

        public void Trabajar()
        {
            miCaldera.Temperatura -= 5;

            if (miCaldera.Temperatura < 60 && miCaldera.Combustible > 0)
                miCaldera.ColocarEstado(miCaldera.Calentando);
        }

        public void CortarFuego()
        {
            Console.WriteLine("No hay fuego prendido");
        }

        public void PonerCombustible()
        {
            Console.WriteLine("Colocando combustible");
            miCaldera.Combustible += 28;
        }

        public void ForzarFuego()
        {
            if(miCaldera.Combustible > 0)
            {
                Console.WriteLine("Se ha prendido el fuego de manera forzada");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;

                if (miCaldera.Temperatura > 100)
                    miCaldera.ColocarEstado(miCaldera.Alarma);
            }
        }

        public override string ToString()
        {
            return string.Format("Espera-> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }
    }
}
