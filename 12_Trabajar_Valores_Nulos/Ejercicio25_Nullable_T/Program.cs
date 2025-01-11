using System;

namespace EdadNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? edad = null;

            Console.WriteLine("Por favor, introduzca su edad (o presione Enter para dejarla vacía):");
            string entrada = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entrada))
            {
                if (int.TryParse(entrada, out int edadIngresada))
                {
                    edad = edadIngresada;
                }
                else
                {
                    Console.WriteLine("La entrada no es un número válido.");
                }
            }

            if (edad.HasValue)
            {
                Console.WriteLine($"La edad ingresada es: {edad.Value} años.");
            }
            else
            {
                Console.WriteLine("No se ingresó ninguna edad.");
            }
        }
    }
}
