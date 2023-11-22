using System.Diagnostics.Contracts;

public class ClaseArray
{
    //Propiedades
    public int[] ArrayEnteros;

    //Constructor
    public ClaseArray()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }

    //Metodos (Procedimientos/Funciones)
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public void InvertirSegundaMitad()
    {
        int n = ArrayEnteros.Length;

        // Verificar si el array tiene al menos dos elementos
        if (n >= 2)
        {
            // Calcular el índice medio
            int mitad = n / 2;

            // Invertir la segunda mitad del array
            for (int i = mitad; i < n - 1; i++)
            {
                int temp = ArrayEnteros[i];
                ArrayEnteros[i] = ArrayEnteros[n - (i - mitad) - 1];
                ArrayEnteros[n - (i - mitad) - 1] = temp;
            }
        }
        else
        {
            Console.WriteLine("El array debe tener al menos dos elementos para invertir la segunda mitad.");
        }
    }

    public void UnirArray(ClaseArray B)
    {
        int n1 = ArrayEnteros.Length;
        int n2 = B.ArrayEnteros.Length;
        int newN = n1 + n2;
        ClaseArray C = new ClaseArray(newN);
        for (int i = 0; i <= n1 - 1; i++)
        {
            C.ArrayEnteros[i] = ArrayEnteros[i];
        }
        for (int j = 0; j <= n2 - 1; j++)
        {
            C.ArrayEnteros[n1 + j] = B.ArrayEnteros[j];
        }
        ArrayEnteros = C.ArrayEnteros;

    }

    public void OrdenarAscendentemente()
    {
        int n = ArrayEnteros.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (ArrayEnteros[i] > ArrayEnteros[j])
                {
                    int temp = ArrayEnteros[i];
                    ArrayEnteros[i] = ArrayEnteros[j];
                    ArrayEnteros[j] = temp;
                }
            }
        }
    }

    public void OrdenarDescendentemente()
    {
        int n = ArrayEnteros.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (ArrayEnteros[i] < ArrayEnteros[j])
                {
                    int temp = ArrayEnteros[i];
                    ArrayEnteros[i] = ArrayEnteros[j];
                    ArrayEnteros[j] = temp;
                }
            }
        }
    }

}