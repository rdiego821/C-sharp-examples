namespace FabricaAbstracta
{
    class SaborChocolate : IProductoSaborizante
    {
        public string Informacion()
        {
            return "de coco";
        }

        public void Obtener()
        {
            System.Console.WriteLine("leche de coco");
        }
    }
}