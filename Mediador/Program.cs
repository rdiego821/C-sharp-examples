using System;

namespace Mediador01
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediador miMediador = new Mediador();

            ColegaA Ana = new ColegaA("Ana", miMediador);
            ColegaA Luis = new ColegaA("Luis", miMediador);

            ColegaB David = new ColegaB("David", miMediador);

            Ana.Enviar("Saludos a todos");
            Luis.Enviar("Como estan?");
            David.Enviar("Saludos");
            Console.WriteLine();

            Console.WriteLine("**** Verificamos censura ****");
            Luis.Enviar("Las palabrotas no me agradan");
            Console.WriteLine();

            miMediador.Bloqueo(Luis.Recibir);
            Ana.Enviar("Vean los playlist");
            Console.WriteLine();

            miMediador.Suscribir(Luis.Recibir);
            David.Enviar("Me gusta programar");
            Console.WriteLine();


        }
    }
}
