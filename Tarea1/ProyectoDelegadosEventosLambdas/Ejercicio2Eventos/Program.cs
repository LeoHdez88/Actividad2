namespace Ejercicio2Eventos;
using System;
class MiClase
{
    public event EventHandler MiEvento;
    public void RealizarAccion()
    {
        Console.WriteLine("Realizando alguna acción...");
        OnMiEvento();
    }
    protected virtual void OnMiEvento()
    {
        MiEvento?.Invoke(this, EventArgs.Empty);
    }
}
class Program
{
    static void Main()
    {
        MiClase miObjeto = new MiClase();
        miObjeto.MiEvento += ManejarEvento;
        miObjeto.RealizarAccion();
        Console.WriteLine("Hello, World!");
    }
    static void ManejarEvento(object sender, EventArgs e)
    {
        Console.WriteLine("Evento manejado con éxito.");
    }
}
