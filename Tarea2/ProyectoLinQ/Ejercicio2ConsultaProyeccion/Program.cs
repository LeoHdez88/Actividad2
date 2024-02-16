namespace Ejercicio2ConsultaProyeccion;
using System;
using System.Linq;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
                new Estudiante { Nombre = "Juan", Edad = 20 },
                new Estudiante { Nombre = "Ana", Edad = 22 },
                new Estudiante { Nombre = "Pedro", Edad = 17 },
                new Estudiante { Nombre = "María", Edad = 25 }
        };

        var nombresMayoresDe18 = from estudiante in estudiantes
                                 where estudiante.Edad > 18
                                 select estudiante.Nombre;

        Console.WriteLine("Nombres de Estudiantes Mayores de 18 años:");

        foreach (var nombre in nombresMayoresDe18)
        {
            Console.Write(nombre + " ");
        }
    }
}
