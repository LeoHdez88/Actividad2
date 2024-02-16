namespace Ejercicio3Lambdas;
using System;
public delegate int OperacionMatematica(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        OperacionMatematica operacion = (a, b) => a + b;
        Console.WriteLine("Suma: " + operacion(5, 3));
        operacion = (a, b) => a - b;
        Console.WriteLine("Resta: " + operacion(5, 3));

        Console.WriteLine("Hello, World!");
    }
}
