using System;

namespace Mediador01
{
    internal class ColegaB : IColega
    {
        private Mediador mediador;
        private string nombre;
        private int conteo;

        public ColegaB(string pNombre, Mediador pMediador)
        {
            nombre = pNombre;

            mediador = pMediador;

            mediador.Suscribir(Recibir);
        }

        public void Recibir(string emisor, string mensaje)
        {
            conteo++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<-[{0},{1}]({2}): {3}", nombre, emisor, conteo, mensaje);
        }

        public void Enviar(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->[{0}]:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}