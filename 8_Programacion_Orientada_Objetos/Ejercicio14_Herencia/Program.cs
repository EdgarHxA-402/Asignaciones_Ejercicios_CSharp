using System;

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
            Perro perro = new Perro { Nombre = "Firulais" };
            perro.Hablar();
            Gato gato = new Gato { Nombre = "Turbo Abuela" };
            gato.Hablar();
            Animal animal = new Perro { Nombre = "Iggy" };
            animal.Hablar();
            animal = new Gato { Nombre = "Tom" };
            animal.Hablar();
        }
    }
}
