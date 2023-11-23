public class ClaseArray
{
    // Propiedades
    public int[] ArrayEnteros;

    // Constructor
    public ClaseArray(int inicioRango, int finRango)
    {
        int longitudSerie = (finRango - inicioRango + 1) * 2;
        ArrayEnteros = new int[longitudSerie];
        GenerarSerieAlternanteRecursiva(inicioRango, finRango, 0);
    }

    // Método
    public void MostrarArray()
    {
        Console.Write("[");
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            Console.Write(ArrayEnteros[i]);
            if (i < ArrayEnteros.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    private void GenerarSerieAlternanteRecursiva(int inicioRango, int finRango, int indice)
    {
        if (indice < ArrayEnteros.Length)
        {
            if (indice % 2 == 0)
            {
                // Números pares, ascendente
                ArrayEnteros[indice] = inicioRango + indice / 2;
            }
            else
            {
                // Números impares, descendente
                ArrayEnteros[indice] = finRango - indice / 2;
            }

            GenerarSerieAlternanteRecursiva(inicioRango, finRango, indice + 1);
        }
    }
}
