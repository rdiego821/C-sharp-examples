using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton1
{
    class Singleton
    {
        private static Singleton instancia;

        private string nombre;
        private int edad;

        private Singleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static Singleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                Console.WriteLine("Instancia creada por primera vez");
            }

            return instancia;
        }

        public override string ToString()
        {
            return string.Format("La persona {0} tiene edad de {1}", nombre, edad);
        }

        public void PonerDatos(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo", nombre);
        }
    }
}
