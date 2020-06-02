using System;
using System.Collections.Generic;
using System.Text;

namespace Observador01
{
    class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;

        public Observador(string pNombre, Sujeto pSujeto)
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribir(this);
        }

        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0}-{1}", nombre, mensaje);
        }


        public void UpdatePull()
        {
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pull, {0}-{1}", nombre, n);
        }
    }
}
