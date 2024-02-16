namespace Ejercicio3ConsultaOrdenamientoyFiltrado;

using System;
using System.Linq;
using System.Collections.Generic;
class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Categoria { get; set; }
}

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 1200, Categoria = "Electrónicos" },
            new Producto { Nombre = "Teléfono", Precio = 800, Categoria = "Electrónicos" },
            new Producto { Nombre = "Libro", Precio = 20, Categoria = "Libros" },
            new Producto { Nombre = "Cámara", Precio = 500, Categoria = "Electrónicos" },
            new Producto { Nombre = "Bicicleta", Precio = 300, Categoria = "Deportes" }
        };

        string categoriaElegida = "Electrónicos";

        var productosFiltrados = from producto in productos
                                 where producto.Categoria == categoriaElegida
                                 orderby producto.Precio
                                 select producto;

        Console.WriteLine($"Productos de la categoría '{categoriaElegida}' ordenados por precio: ");

        foreach (var producto in productosFiltrados)
        {
            Console.WriteLine($"{producto.Nombre} - ${producto.Precio}");
        }
    }
}

