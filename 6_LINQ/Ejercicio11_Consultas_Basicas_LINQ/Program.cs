using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 10, 15, 7, 22, 3, 9, 18, 27, 5 };
            var ImparesDescendentes = numeros
                .Where(n => n % 2 != 0)
                .OrderByDescending(n => n) 
                .ToList();               

            Console.WriteLine("Números impares por orden descendente:");
            foreach (var numero in ImparesDescendentes)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
