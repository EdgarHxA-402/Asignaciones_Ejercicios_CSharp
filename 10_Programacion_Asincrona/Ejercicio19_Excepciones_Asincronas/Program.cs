using System;
using System.Threading.Tasks;

namespace OperacionAsincrona
{
    class Program
    {
        public static async Task<int> OperacionLargaAsync()
        {
            Random random = new Random();
            Console.WriteLine("Inicio de la operación larga...");
            await Task.Delay(2000);

            if (random.Next(1, 10) > 7)
            {
                throw new InvalidOperationException("Ocurrió un error en la operación larga.");
            }

            int numeroAleatorio = random.Next(1, 101);
            Console.WriteLine("Operación larga finalizada.");
            return numeroAleatorio;
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Llamando a las operaciones de forma concurrente...");

            try
            {
                Task<int> tarea1 = OperacionLargaAsync();
                Task<int> tarea2 = OperacionLargaAsync();
                int[] resultados = await Task.WhenAll(tarea1, tarea2);

                Console.WriteLine($"Resultado de la primera operación: {resultados[0]}");
                Console.WriteLine($"Resultado de la segunda operación: {resultados[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo una excepción: {ex.Message}");
            }
        }
    }
}
