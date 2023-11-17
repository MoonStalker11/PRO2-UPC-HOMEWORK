public class ClaseArray{
    //Propiedades
    public int[] ArrayEnteros;
    
    //Constructor
    public ClaseArray(){
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad){
        ArrayEnteros = new int[cantidad];
    }

    //Metdos (Procedimientos/Funciones)
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public void MostraMaxMinArrayEnteros()
    {
        if (ArrayEnteros.Length == 0)
        {
            Console.WriteLine("El array está vacío.");
            return;
        }

        int maximo = ArrayEnteros[0];
        int minimo = ArrayEnteros[0];

        for (int i = 1; i < ArrayEnteros.Length; i++)
        {
            if (ArrayEnteros[i] > maximo)
            {
                maximo = ArrayEnteros[i];
            }

            if (ArrayEnteros[i] < minimo)
            {
                minimo = ArrayEnteros[i];
            }
        }

        Console.WriteLine($"El valor máximo del array es: {maximo}");
        Console.WriteLine($"El valor mínimo del array es: {minimo}");
    }

    public int SumaArrayEnteros()
    {
        int suma = 0;

        foreach (int numero in ArrayEnteros)
        {
            suma += numero;
        }

        Console.WriteLine($"La suma de los elementos del array es: {suma}");

        return suma;
    }

    public int PromedioArrayEnteros()
    {
        if (ArrayEnteros.Length == 0)
        {
            Console.WriteLine("No se puede calcular el promedio, el array está vacío.");
            return 0;
        }

        int suma = 0;
        foreach (int numero in ArrayEnteros)
        {
            suma += numero;
        }

        int promedio = suma / ArrayEnteros.Length;

        Console.WriteLine($"El promedio de los elementos del array es: {promedio}");

        return promedio;
    }

    public int FrecuenciaArrayEnteros(int elemento)
    {
        int frecuencia = 0;

        foreach (int numero in ArrayEnteros)
        {
            if (numero == elemento)
            {
                frecuencia++;
            }
        }

        Console.WriteLine($"La frecuencia del elemento {elemento} en el array es: {frecuencia}");

        return frecuencia;
    }

    public void ArrayEnterosToArrayCadenas()
    {
        if (ArrayEnteros == null || ArrayEnteros.Length == 0)
        {
            Console.WriteLine("El array de enteros está vacío o es nulo.");
            return;
        }

        string[] arrayCadenas = new string[ArrayEnteros.Length];

        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
        // Verificar si el valor tiene una representación imprimible en ASCII
            if (ArrayEnteros[i] >= 32 && ArrayEnteros[i] <= 126)
            {
                arrayCadenas[i] = ((char)ArrayEnteros[i]).ToString();
            }
            else
            {
            arrayCadenas[i] = ""; // O puedes asignar otro valor como "[No imprimible]"
            }
        }

    Console.WriteLine("Array de Enteros:");
    MostrarArray(ArrayEnteros);

    Console.WriteLine("\nArray de Cadenas (Equivalencia ASCII):");
    MostrarArrayCadenas(arrayCadenas);
    }

// Método MostrarArray para mostrar un array de enteros en la consola
    public void MostrarArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

// Método MostrarArrayCadenas para mostrar un array de cadenas en la consola
    private void MostrarArrayCadenas(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}

