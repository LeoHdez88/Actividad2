namespace Ejercicio1TareaBasicaAsinc;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Iniciando programa...");
        await MiTareaAsincrona();
        Console.WriteLine("Programa completado.");
        Console.WriteLine("Hello, World!");
    }

    static async Task MiTareaAsincrona()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Realizando tarea asíncrona...");
            // Simula una operación asíncrona
            Task.Delay(2000).Wait();
        });
    }

}
