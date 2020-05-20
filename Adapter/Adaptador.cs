namespace Adapter
{
    internal class Adaptador : ITarget
    {
        CalculadoraArray adaptado = new CalculadoraArray();

        public int Sumar(int v1, int v2)
        {
            double r = 0;
            int[] operadores = { v1, v2 };
            r = adaptado.Suma(operadores);

            return (int)r;
        }
    }
}