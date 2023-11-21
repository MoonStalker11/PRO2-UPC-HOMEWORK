using System;

namespace RecursividadDemo
{
    public class RecursividadDemo
    {
        public int CalcularFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalcularFactorial(n - 1);
            }
        }
    }
}
