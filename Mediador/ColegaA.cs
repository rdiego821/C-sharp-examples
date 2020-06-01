using Mediador01;
using System;

namespace Mediador01
{
    internal class ColegaA : IColega
    {
        private Mediador mediador;
        private string nombre;

        public ColegaA(string pNombre, Mediador pMediador)
        {
            nombre = pNombre;
            mediador = pMediador;
            mediador.Suscribir(Recibir);
        }
        public void Recibir(string emisor, string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, recibi de {1}: {2}", nombre, emisor, mensaje);
        }

        public void Enviar(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, envio:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}