using System;

namespace RecursividadDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RecursividadDemo demo = new RecursividadDemo();

            Console.Write("Ingrese un número para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = demo.CalcularFactorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }
    }
}