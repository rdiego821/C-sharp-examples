using System;

namespace FabricaAbstracta
{
    class LecheCoco : IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Partir cocos");
        }

        public string ObtenDatos()
        {
            return "leche de coco, 250 ml";
        }
    }
}