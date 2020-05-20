using System;

namespace Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminPrototipos admin = new AdminPrototipos();


            Persona uno = (Persona)admin.ObtenPrototipos("Persona");
            Persona dos = (Persona)admin.ObtenPrototipos("Persona");

            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("------");

            uno.nombre = "Ana";
            dos.nombre = "Chepe";

            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("----");

            Auto auto = new Auto("Nissan", 250000);

            admin.AdicionaPrototipo("Auto", auto);

            Auto auto2 = (Auto)admin.ObtenPrototipos("Auto");
            auto2.modelo = "Honda";

            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-----");

            Valores val = (Valores)admin.ObtenPrototipos("Valores");
            Console.WriteLine(val);



        }
    }
}
