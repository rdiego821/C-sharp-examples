using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class LecheVaca : IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Ordeniar vaca en la granja");
        }

        public string ObtenDatos()
        {
            return "leche de vaca, 250 ml";
        }
    }
}
