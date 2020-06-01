using System;
using System.Collections.Generic;
using System.Text;

namespace Mediador01
{
    class Mediador
    {
        public delegate void DEnvio(string emisor, string mensaje);
        DEnvio enviarMensaje;

        public void Suscribir(DEnvio metodo)
        {
            enviarMensaje += metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---- Suscrito ---");
        }

        public void Enviar(string emisor, string mensaje)
        {
            if (mensaje.Contains("palabrota"))
                mensaje = mensaje.Replace("palabrota", "******");

            enviarMensaje(emisor, mensaje);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Mensajes enviados ---");
        }

        public void Bloqueo(DEnvio metodo)
        {
            enviarMensaje -= metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Bloqueo ---");
        }
    }
}
