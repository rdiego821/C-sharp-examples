using System.Collections;

namespace Iterador
{
    internal class Contenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public Contenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }

    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }
}