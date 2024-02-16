namespace Ejercicio3ManejodeErroresAsincronos;

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            Console.WriteLine("Iniciando programa...");
            await RealizarOperacionAsync();
            Console.WriteLine("Programa completado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    static async Task RealizarOperacionAsync()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Realizando operación asíncrona con error...");
            // Simula una operación que lanza una excepción
            throw new Exception("Algo salió mal.");
        });
    }

}
