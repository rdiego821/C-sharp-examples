using System;
using System.Collections.Generic;
using System.Text;

namespace Memento01
{
    [Serializable]
    class Originador
    {
        private string nombre;
        private int modelo;
        private double costo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }

        public Originador(string pNombre, int pModelo, double pCosto)
        {
            nombre = pNombre;
            modelo = pModelo;
            costo = pCosto;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} {1}, con costo de ${2}", nombre, modelo, costo);
        }

        public Memento CreaMemento()
        {
            Memento miMemento = new Memento();
            miMemento.Salvar(this);
            return miMemento;
        }

        public void Restaura(Memento pMemento)
        {
            Originador temp = pMemento.Restaurar();
            nombre = temp.Nombre;
            modelo = temp.Modelo;
            costo = temp.Costo;
        }
    }
}
