using System;

namespace EjercicioDelegados
{
    public delegate int OperacionAritmetica(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            OperacionAritmetica operacion = Sumar;
            int resultadoSuma = operacion(numero1, numero2);
            Console.WriteLine($"Resultado de la suma: {resultadoSuma}");

            operacion = Multiplicar;
            int resultadoMultiplicacion = operacion(numero1, numero2);
            Console.WriteLine($"Resultado de la multiplicación: {resultadoMultiplicacion}");
        }

        // Metodo de la suma
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        // Metoso de la multiplicacion
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}
