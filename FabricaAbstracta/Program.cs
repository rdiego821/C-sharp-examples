using System;

namespace FabricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new FabricaQuimica();
            miFabrica.crearProductos();
            IProductoLeche miLeche = miFabrica.ObtenProductoLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.Producir();
            miSabor.Obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenDatos(), miSabor.Informacion());
            Console.WriteLine("------");

            miFabrica = new FabricaNatural();
            miFabrica.crearProductos();

            miLeche = miFabrica.ObtenProductoLeche;
            miSabor = miFabrica.ObtenSabor;
            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenDatos(), miSabor.Informacion());
        }
    }
}
