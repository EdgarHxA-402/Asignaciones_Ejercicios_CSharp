using System;
using System.Linq;

namespace MetodosExtension
{
    public static class StringExtensions
    {
        public static int ContarVocales(this string texto, char vocal)
        {
            char[] vocalesValidas = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            if (!vocalesValidas.Contains(vocal))
            {
                throw new ArgumentException("El carácter ingresado no es una vocal.");
            }

            return texto.Count(c => char.ToLower(c) == char.ToLower(vocal));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una oración:");
            string texto = Console.ReadLine();

            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("\nResultados:");
            foreach (char vocal in vocales)
            {
                int cantidad = texto.ContarVocales(vocal);
                Console.WriteLine($"La vocal '{vocal}' aparece {cantidad} veces.");
            }
        }
    }
}
