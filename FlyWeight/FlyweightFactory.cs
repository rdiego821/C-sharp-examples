using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    class FlyweightFactory
    {
        private List<IFlyWeight> flyWeights = new List<IFlyWeight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string pNombre)
        {
            bool existe = false;

            foreach (IFlyWeight f in flyWeights)
            {
                if (f.ObtenNombre() == pNombre)
                    existe = true;
            }

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                Receta miReceta = new Receta();
                miReceta.ColocaNombre(pNombre);
                flyWeights.Add(miReceta);
                conteo = flyWeights.Count;
                return conteo - 1;
            }
        }

        public IFlyWeight this[int index]
        {
            get { return flyWeights[index]; }
        }
    }
}
