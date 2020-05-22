using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> pProductos);
        void ListarProductos(Dictionary<string, double> pProductos);

    }
}
