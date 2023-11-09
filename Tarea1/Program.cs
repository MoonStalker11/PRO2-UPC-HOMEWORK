namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AREA CUADRADA");
            int resp = calcularAreaCuadrado(10);
            Console.WriteLine(resp);

            static int calcularAreaCuadrado(int L){
                int resultado = L*L;
                return resultado;
            }
        }

    }
}