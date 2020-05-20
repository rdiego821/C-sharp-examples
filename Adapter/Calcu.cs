namespace Adapter
{
    internal class Calcu : ITarget
    {
        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }
    }
}