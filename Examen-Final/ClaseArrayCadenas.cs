public class ClaseArrayCadenas
{
    public string[] ArrayCadenas;

    public ClaseArrayCadenas()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArrayCadenas(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public void GenerarSerieExamenIterativo(bool sw, int numA, int numB, int cantidadElementos)
    {
        for (int i = 0; i < cantidadElementos; i++)
        {
            if (sw)
            {
                ArrayCadenas[i] = numA.ToString();
                numA *= 10;
                sw = false;
            }
            else
            {
                ArrayCadenas[i] = numB.ToString();
                numB += 100;
                sw = true;
            }
        }
    }

}