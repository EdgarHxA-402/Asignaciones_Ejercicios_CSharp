using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DescargaArchivos
{
    class Program
    {
        public static async Task DescargarArchivoAsync(string nombreArchivo, int tiempoDescarga)
        {
            Console.WriteLine($"Iniciando la descarga de {nombreArchivo}...");
            await Task.Delay(tiempoDescarga);
            Console.WriteLine($"Descarga completada: {nombreArchivo} (Duración: {tiempoDescarga / 1000} segundos).");
        }

        static async Task Main(string[] args)
        {
            Stopwatch cronometro = Stopwatch.StartNew();

            Task tarea1 = DescargarArchivoAsync("Archivo1.txt", 2000); 
            Task tarea2 = DescargarArchivoAsync("Archivo2.txt", 3000);
            Task tarea3 = DescargarArchivoAsync("Archivo3.txt", 1500);

            await Task.WhenAll(tarea1, tarea2, tarea3);
            cronometro.Stop();

            Console.WriteLine($"Todas las descargas completadas en {cronometro.Elapsed.TotalSeconds:F2} segundos.");
        }
    }
}
