namespace Enteros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(4);
            A.ArrayEnteros[0] = 65;
            A.ArrayEnteros[1] = 66;
            A.ArrayEnteros[2] = 67;
            A.ArrayEnteros[3] = 68;
            
            Console.WriteLine("Array Enteros");
            A.MostrarArray();
            Console.WriteLine("-------------------------------------------------");
            A.MostraMaxMinArrayEnteros();
            A.SumaArrayEnteros();
            A.PromedioArrayEnteros();
            A.FrecuenciaArrayEnteros(65);
            A.ArrayEnterosToArrayCadenas();

            Console.WriteLine("-------------------------------------------------");

            ClaseArray2 B = new ClaseArray2(4);
            B.ArrayCadenas[0] = "Sol";
            B.ArrayCadenas[1] = "Pan";
            B.ArrayCadenas[2] = "Te";
            B.ArrayCadenas[3] = "Rosa";
            B.MostrarArray2();
            Console.WriteLine("-------------------------------------------------");
            ClaseArray2 C = new ClaseArray2(4);
            C.ArrayCadenas[0] = "Azul";
            C.ArrayCadenas[1] = "Te";
            C.ArrayCadenas[2] = "Pan";
            C.ArrayCadenas[3] = "Buey";
            C.MostrarArray2();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(B.BuscarElementoArrayCadenas("Sol"));
            B.FrecuenciaArrayCadenas("Sol");
            B.ComplementoArrayCadenasAyB(B.ArrayCadenas, C.ArrayCadenas);
            B.ArrayCadenasToArrayEnteros();
            B.DiferenciaArrayCadenasAyB(C);
            B.InvertirArrayCadenas();
            C.DiferenciaArrayCadenasByA(B);
            


        } 
    }
}