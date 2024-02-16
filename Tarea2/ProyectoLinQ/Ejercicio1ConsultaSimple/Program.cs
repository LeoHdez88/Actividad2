namespace Ejercicio1ConsultaSimple;
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var numerosPares = from num in numeros where num % 2 == 0 select num;
        Console.WriteLine("Números Pares:");
        foreach (var numero in numerosPares)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine("Hello, World!");
    }
}
