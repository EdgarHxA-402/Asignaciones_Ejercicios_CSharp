using System;

namespace GenerarNumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int contador = 0;

            Console.WriteLine("Generando números aleatorios del 1 al 100...");

            while (contador < 10)
            {
                int numero = random.Next(1, 100);
                Console.WriteLine(numero);
                //contador++; solucion logica
            }

            Console.WriteLine("Fin del programa.");
        }
    }
}
