public class ClaseArray2{
    //Propiedades
    public string[] ArrayCadenas;
    
    //Constructor
    public ClaseArray2(){
        ArrayCadenas = new string[0];
    }

    public ClaseArray2(int cantidad){
        ArrayCadenas = new string[cantidad];
    }

    public void MostrarArray2()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }
    
    public string BuscarElementoArrayCadenas(string elemento)
    {
        bool encontrado = false;

        foreach (string cadena in ArrayCadenas)
        {
            if (cadena == elemento)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            return"TRUE";
        }
        else
        {
            return "FALSE";
        }
        

    }

    public int FrecuenciaArrayCadenas(string elemento)
    {
        int frecuencia = 0;

        foreach (string cadena in ArrayCadenas)
        {
            if (cadena == elemento)
            {
                frecuencia++;
            }
        }

        Console.WriteLine($"La frecuencia de '{elemento}' en el array es: {frecuencia}");

        return frecuencia;
    }

    public void ComplementoArrayCadenasAyB(string[] arrayA, string[] arrayB)
    {
        // Verificar si alguno de los arrays es nulo o vacío
        if (arrayA == null || arrayB == null || arrayA.Length == 0 || arrayB.Length == 0)
        {
            Console.WriteLine("Los arrays A y B deben tener elementos.");
            return;
        }

        // Obtener el complemento de A y B
        var complemento = arrayA.Except(arrayB).ToArray();

        // Mostrar el complemento
        Console.WriteLine("Complemento de A y B:");
        MostrarArray2(complemento);
    }

    public void MostrarArray2(string[] array)
    {
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

    
    public void ArrayCadenasToArrayEnteros()
    {
        // Verificar si el array de cadenas es nulo o vacío
        if (ArrayCadenas == null || ArrayCadenas.Length == 0)
        {
            Console.WriteLine("El array de cadenas debe tener elementos.");
            return;
        }

        // Recorrer cada cadena y mostrar los valores ASCII de cada letra
        foreach (var cadena in ArrayCadenas)
        {
            Console.Write($"{cadena} = ");
            foreach (var letra in cadena)
            {
                Console.Write($"{letra}: {(int)letra} - ");
            }
            Console.WriteLine();
        }
    }

    public void DiferenciaArrayCadenasAyB(ClaseArray2 arrayB)
    {
        // Verificar si ambos arrays tienen elementos
        if (ArrayCadenas == null || ArrayCadenas.Length == 0 || arrayB == null || arrayB.ArrayCadenas == null || arrayB.ArrayCadenas.Length == 0)
        {
            Console.WriteLine("Ambos arrays deben tener elementos.");
            return;
        }

        // Crear una lista para almacenar la diferencia
        List<string> diferencia = new List<string>();

        // Obtener la diferencia A - B
        foreach (var cadenaA in ArrayCadenas)
        {
            if (!arrayB.ArrayCadenas.Contains(cadenaA))
            {
                diferencia.Add(cadenaA);
            }
        }

        // Mostrar el array de diferencia
        MostrarArrayDiferencia(diferencia);
    }

    // Método para mostrar un array de diferencia
    private void MostrarArrayDiferencia(List<string> array)
    {
        Console.WriteLine("Array de diferencia (A - B):");
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

    public void InvertirArrayCadenas()
    {
        // Verificar si el array de cadenas es nulo o vacío
        if (ArrayCadenas == null || ArrayCadenas.Length == 0)
        {
            Console.WriteLine("El array de cadenas debe tener elementos.");
            return;
        }

        // Invertir el array de cadenas
        Array.Reverse(ArrayCadenas);

        // Mostrar el array invertido
        MostrarArrayInvertido();
    }

    // Método para mostrar un array invertido
    private void MostrarArrayInvertido()
    {
        Console.WriteLine("Array de cadenas invertido:");
        MostrarArray2();
    }

    public void DiferenciaArrayCadenasByA(ClaseArray2 arrayA)
    {
        // Verificar si ambos arrays tienen elementos
        if (ArrayCadenas == null || ArrayCadenas.Length == 0 || arrayA == null || arrayA.ArrayCadenas == null || arrayA.ArrayCadenas.Length == 0)
        {
            Console.WriteLine("Ambos arrays deben tener elementos.");
            return;
        }

        // Crear una lista para almacenar la diferencia
        List<string> diferencia = new List<string>();

        // Obtener la diferencia B - A
        foreach (var cadenaB in ArrayCadenas)
        {
            if (!arrayA.ArrayCadenas.Contains(cadenaB))
            {
                diferencia.Add(cadenaB);
            }
        }

        // Mostrar el array de diferencia
        MostrarDiferencia(diferencia);
    }

    // Método modificado para mostrar la diferencia
    private void MostrarDiferencia(List<string> array)
    {
        Console.WriteLine("Array de diferencia (B - A):");
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

}