using System;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Propietario elPropietario = new Propietario();
            JefePiso elJefe = new JefePiso(elPropietario);
            Vendedor elVendedor = new Vendedor(elJefe);

            int cantidad = 100;
            double precio = 2000;
            double total = 0;

            total = elVendedor.CalculaPrecioFinal(cantidad, precio);

            Console.WriteLine("total {0}, con descuento {1}", cantidad * precio, total);
        }
    }
}
