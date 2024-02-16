namespace Ejercicio2MultiplesTareasConcurrente;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Iniciando programa...");
        List<Task> tareas = new List<Task>
        {
            RealizarTareaAsync("Tarea 1"),
            RealizarTareaAsync("Tarea 2"),
            RealizarTareaAsync("Tarea 3")
        };
        await Task.WhenAll(tareas);
        Console.WriteLine("Programa completado.");
    }
    static async Task RealizarTareaAsync(string nombreTarea)
    {
        await Task.Run(() =>
        {
            Console.WriteLine($"Realizando {nombreTarea}...");
            Task.Delay(2000).Wait();
        });
    }
}
