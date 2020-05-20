using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class VainillaNatural : IProductoSaborizante
    {
        public string Informacion()
        {
            return "Extracto natural de vainilla";
        }

        public void Obtener()
        {
            Console.WriteLine("Se extrae de las vainas");
        }
    }
}
