using System;

public class Entero
{
    // Propiedades
    public int N;

    // Constructor
    public Entero()
    {
        N = 0;
    }

    public Entero(int num)
    {
        N = num;
    }

    // Métodos (Procedimientos/Funciones)
    public int SumarDigitos()
    {
        int suma = 0;
        int NroAux = N;

        while (NroAux != 0)
        {
            int dig = NroAux % 10;
            suma += dig;
            NroAux = NroAux / 10;
        }

        return suma;
    }

    public int ObtenerDigitoMayor()
    {
        int mayor = 0;
        int NroAux = N;

        while (NroAux != 0)
        {
            int dig = NroAux % 10;
            if (dig > mayor)
            {
                mayor = dig;
            }
            NroAux = NroAux / 10;
        }

        return mayor;
    }

    public int ObtenerDigitoMenor()
    {
        int menor = 9; // Inicializamos con el dígito más grande posible (9) para asegurarnos de encontrar un número menor.

        int NroAux = N;

        while (NroAux != 0)
        {
            int dig = NroAux % 10;
            if (dig < menor)
            {
                menor = dig;
            }
            NroAux = NroAux / 10;
        }

        return menor;
    }

    public int FibonacciDelDigitoMenor()
    {
        int digitoMenor = ObtenerDigitoMenor();
        int a = 0, b = 1;

        for (int i = 0; i < digitoMenor; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a;
    }
}