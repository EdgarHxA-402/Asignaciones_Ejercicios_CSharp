using System;

namespace OperadorCondicionalNulo
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona { Nombre = "Juan" };
            string mensaje = persona.Apellido?.ToUpper() ?? "El apellido no está asignado.";

            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Apellido: {mensaje}");
        }
    }
}
