using System;

namespace OperadorFusionNula
{
    class Program
    {
        static void Main(string[] args)
        {
            int? numeroNullable = null;
            int numeroPorDefecto = numeroNullable ?? 100;

            Console.WriteLine($"Valor de la variable nullable: {numeroNullable}");
            Console.WriteLine($"Valor final (con fusión nula): {numeroPorDefecto}");
        }
    }
}
