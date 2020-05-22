using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.56);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);

            //Abstraccion bridge = new Abstraccion(new Implementacion3(), productos);

            Abstraccion bridge = new Abstraccion(2, productos);


            bridge.MostrarTotales();
            bridge.Listar();

        }
    }
}
