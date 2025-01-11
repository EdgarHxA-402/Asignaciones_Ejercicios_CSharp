using System;
using System.Collections.Generic;
using System.Linq;

namespace AgruparProductos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto { Nombre = "Manzana", Precio = 10m, Categoria = "Frutas" },
                new Producto { Nombre = "Banana", Precio = 16m, Categoria = "Frutas" },
                new Producto { Nombre = "Zanahoria", Precio = 25m, Categoria = "Verduras" },
                new Producto { Nombre = "Brócoli", Precio = 11m, Categoria = "Verduras" },
                new Producto { Nombre = "Pollo", Precio = 50m, Categoria = "Carnes" },
                new Producto { Nombre = "Res", Precio = 75m, Categoria = "Carnes" },
                new Producto { Nombre = "Pera", Precio = 13m, Categoria = "Frutas" },
            };
            var productosAgrupados = productos
                .GroupBy(p => p.Categoria)
                .Select(grupo => new
                {
                    Categoria = grupo.Key,
                    PrecioPromedio = grupo.Average(p => p.Precio)
                });

            Console.WriteLine("Precio promedio por categoría:");
            Console.WriteLine("==============================");
            foreach (var grupo in productosAgrupados)
            {
                Console.WriteLine($"Categoría: {grupo.Categoria}, Precio promedio: {grupo.PrecioPromedio:C}");
                Console.WriteLine("========================================================================");

            }
        }
    }
}
