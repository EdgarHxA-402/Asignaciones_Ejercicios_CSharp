using System;
using System.Collections.Generic;

namespace HerenciaAnimales
{
    public class Animal
    {
        public string Nombre { get; set; }
        public virtual void Hablar()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
    public class Perro : Animal
    {
        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} dice: ¡Guau Guau!");
        }
    }
    public class Gato : Animal
    {
        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} dice: ¡Miau Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>
            {
                new Perro { Nombre = "Firulais" },
                new Gato { Nombre = "Turbo Abuela" },
                new Perro { Nombre = "Iggy" },
                new Gato { Nombre = "Tom" }
            };
            Console.WriteLine("Los animales están hablando:");
            foreach (Animal animal in animales)
            {
                animal.Hablar();
            }
        }
    }
}
