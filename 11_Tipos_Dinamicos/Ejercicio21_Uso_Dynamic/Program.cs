using System;

namespace UsoDynamic
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic objeto = 42;
            Console.WriteLine($"Valor (entero): {objeto}");
            Console.WriteLine($"Doble del valor: {objeto * 2}");
            objeto = "Hola Mundo"; 
            Console.WriteLine($"\nValor (cadena): {objeto}");
            Console.WriteLine($"Longitud de la cadena: {objeto.Length}");
            objeto = new Persona { Nombre = "Juan", Edad = 30 }; 
            Console.WriteLine($"\nValor (objeto personalizado):");
            objeto.Presentarse();

            try
            {
                Console.WriteLine($"\nIntentando invocar un método inexistente...");
                objeto.MetodoInexistente(); 
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine($"Error en tiempo de ejecución: {ex.Message}");
            }
        }
    }
}
