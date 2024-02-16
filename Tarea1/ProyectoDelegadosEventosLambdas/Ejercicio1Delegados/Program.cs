namespace Ejercicio1Delegados;
using System;
public delegate int OperacionMatematica(int a, int b);


class Program
{
    static void Main(string[] args)
    {
        OperacionMatematica operacion = Suma;
        Console.WriteLine("Suma: " + operacion(5, 3));
        operacion = Resta;
        Console.WriteLine("Resta: " + operacion(5, 3));

        Console.WriteLine("Hello, By LeoHdez!");
    }

    static int Suma(int a, int b)
    {
        return a + b;
    }
    static int Resta(int a, int b)
    {
        return a - b;
    }
}
