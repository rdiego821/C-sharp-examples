namespace Subsistemas
{
    class Fachada
    {
        private SistemaCompra compra = new SistemaCompra();
        private SubSistemaAlmacen almacen = new SubSistemaAlmacen();
        private SubsistemaEnvio envio = new SubsistemaEnvio();

        public void Compra()
        {
            if (compra.Comprar())
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido(); 
                }
            }
        }
    }
}