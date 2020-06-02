using System;

namespace Memento01
{
    class Program
    {
        static void Main(string[] args)
        {
            Originador auto = new Originador("March", 2019, 250000);
            auto.Mostrar();

            CareTaker ct = new CareTaker();
            ct.Memento = auto.CreaMemento();

            auto.Nombre = "Vocho";
            auto.Modelo = 1970;
            auto.Costo = 35000;
            auto.Mostrar();

            auto.Restaura(ct.Memento);
            auto.Mostrar();
        }
    }
}
