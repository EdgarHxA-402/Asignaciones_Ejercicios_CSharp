using System;
using System.Collections.Generic;
using System.Linq;

namespace FiltrarEstudiantes
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Juan", Edad = 17 },
                new Estudiante { Nombre = "María", Edad = 20 },
                new Estudiante { Nombre = "Carlos", Edad = 18 },
                new Estudiante { Nombre = "Ana", Edad = 21 },
                new Estudiante { Nombre = "Luis", Edad = 16 }
            };
            List<Estudiante> mayoresDe18 = estudiantes.Where(e => e.Edad > 18).ToList();
            Console.WriteLine("Estudiantes mayores de 18 años:");
            Console.WriteLine("===============================");

            foreach (var estudiante in mayoresDe18)
            {
                Console.WriteLine($"{estudiante.Nombre} ({estudiante.Edad} años)");
            }
        }
    }
}
