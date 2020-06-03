namespace Estado
{
    internal class Caldera
    {
        private IEstado calentando;
        private IEstado alarma;
        private IEstado espera;

        private IEstado estado;

        private int temperatura;
        private int combustible;

        public int Temperatura { get => temperatura; set => temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }
        internal IEstado Calentando { get => calentando; set => calentando = value; }
        internal IEstado Alarma { get => alarma; set => alarma = value; }
        internal IEstado Espera { get => espera; set => espera = value; }

        public Caldera()
        {
            temperatura = 20;
            combustible = 50;

            calentando = new EstadoCalentando(this);
            alarma = new EstadoAlarma(this);
            espera = new EstadoEspera(this);

            estado = calentando;
        }

        public void ColocarEstado(IEstado pEstado)
        {
            System.Console.WriteLine("   Cambio de estado   ");
            estado = pEstado;
        }

        public void Trabajar()
        {
            estado.Trabajar();
        }

        public void CortarFuego()
        {
            estado.CortarFuego();
        }

        public void PonerCombustible()
        {
            estado.PonerCombustible();
        }

        public void ForzarFuego()
        {
            estado.ForzarFuego();
        }

        public override string ToString()
        {
            return estado.ToString();
        }

    }
}