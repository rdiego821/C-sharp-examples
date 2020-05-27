using System;
using System.Collections.Generic;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            FlyweightFactory flywf = new FlyweightFactory();

            i = flywf.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Nopales");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            foreach (int n in Rapida)
            {
                Receta receta = (Receta)flywf[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.WriteLine("-----");

            foreach (int n in Americana)
            {
                Receta receta = (Receta)flywf[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.WriteLine("-----");

            i = flywf.Adiciona("Pizza");

            Console.WriteLine("-----");

            foreach (int n in Ensaladas)
            {
                Receta receta = (Receta)flywf[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }
        }
    }
}
