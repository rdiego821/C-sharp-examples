namespace Decorador
{
    internal class Auto : IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public Auto(string pModelo, string pCaract, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaract;
            costo = pCosto;
        }

        public void Puertas(bool pEstado)
        {
            if(pEstado)
                System.Console.WriteLine("Puertas cerradas");
            else
                System.Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}