namespace ClaseEntero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Entero Nro = new Entero(12345);
            Console.WriteLine("Suma de los dígitos: " + Nro.SumarDigitos());
            Console.WriteLine("Dígito mayor: " + Nro.ObtenerDigitoMayor());
            Console.WriteLine("Dígito menor: " + Nro.ObtenerDigitoMenor());
            Console.WriteLine("Fibonacci del dígito menor: " + Nro.FibonacciDelDigitoMenor());

            ClaseArray A = new ClaseArray(6);
            A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 2;
            A.ArrayEnteros[2] = 3;
            A.ArrayEnteros[3] = 4;
            A.ArrayEnteros[4] = 5;
            A.ArrayEnteros[5] = 6;

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Array A:");
            A.MostrarArray();

            ClaseArray B = new ClaseArray(6);
            B.ArrayEnteros[0] = 30;
            B.ArrayEnteros[1] = 20;
            B.ArrayEnteros[2] = 40;
            B.ArrayEnteros[3] = 60;
            B.ArrayEnteros[4] = 10;
            B.ArrayEnteros[5] = 50;

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Array B:");
            B.MostrarArray();

            Console.WriteLine("--------------------------------------------------------");

            A.InvertirSegundaMitad();
            Console.WriteLine("Array después de invertir la segunda mitad de Array A:");
            A.MostrarArray();

            Console.WriteLine("--------------------------------------------------------");

            A.UnirArray(B);
            Console.WriteLine("\nArray A después de unir con B:");
            A.MostrarArray();

            Console.WriteLine("--------------------------------------------------------");

            B.OrdenarAscendentemente();
            Console.WriteLine("\nArray B después de ordenar ascendentemente:");
            B.MostrarArray();

            Console.WriteLine("--------------------------------------------------------");
            
            B.OrdenarDescendentemente();
            Console.WriteLine("\nArray B después de ordenar descendentemente:");
            B.MostrarArray();
        }
    }
}
