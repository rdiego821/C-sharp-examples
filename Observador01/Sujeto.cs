using System;
using System.Collections.Generic;
using System.Text;

namespace Observador01
{
    class Sujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private Random rnd = new Random();
        private int n;

        public int N { get => n; set => n = value; }

        public void Suscribir(IObservador suscrito)
        {
            observadores.Add(suscrito);
        }

        public void Desuscribir(IObservador suscrito)
        {
            observadores.Remove(suscrito);
        }

        private void Notificar()
        {
            foreach (IObservador o in observadores)
            {
                //o.Update(mensaje);
                o.UpdatePull();
            }
        }

        public void Trabajo()
        {
            n = rnd.Next(10);
            if (n%2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Nuevo estado valido ---");
                mensaje = string.Format("El nuevo valor es {0}", n);
                Notificar();
            }
        }
    }
}
