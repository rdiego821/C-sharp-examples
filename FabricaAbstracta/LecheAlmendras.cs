using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class LecheAlmendras : IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Procesar las almendras");
        }

        public string ObtenDatos()
        {
            return "Leche organica de almendra, 250 ml";
        }

       
    }
}
