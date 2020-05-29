namespace Chain
{
    class JefePiso : IHandler
    {

        private IHandler siguiente = null;

        public JefePiso(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            System.Console.WriteLine("Con el jefe de Piso");

            double total = pCantidad * pPrecio;

            if (pCantidad > 100 || total > 75000)
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            else
            {
                if (pCantidad > 20)
                    total *= 0.9;
            }

            return total;
        }
    }
}
