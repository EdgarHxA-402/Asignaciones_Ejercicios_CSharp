using System;
using System.Collections.Generic;

namespace ClaseGenerica
{
    public class Caja<T>
    {
        private List<T> elementos;
        public Caja()
        {
            elementos = new List<T>();
        }

        public void Añadir(T elemento)
        {
            elementos.Add(elemento);
            Console.WriteLine($"{elemento} ha sido añadido a la caja.");
        }

        public T Obtener(int indice)
        {
            if (indice < 0 || indice >= elementos.Count)
            {
                throw new ArgumentOutOfRangeException("El índice está fuera de rango.");
            }
            return elementos[indice];
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Elementos en la caja:");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Caja<int> cajaEnteros = new Caja<int>();
            cajaEnteros.Añadir(10);
            cajaEnteros.Añadir(20);
            cajaEnteros.Añadir(30);
            cajaEnteros.MostrarElementos();
            int elementoEntero = cajaEnteros.Obtener(1);
            Console.WriteLine($"Elemento obtenido: {elementoEntero}");
            Caja<string> cajaCadenas = new Caja<string>();
            cajaCadenas.Añadir("Hola");
            cajaCadenas.Añadir("Mundo");
            cajaCadenas.MostrarElementos();
            string elementoCadena = cajaCadenas.Obtener(0);
            Console.WriteLine($"Elemento obtenido: {elementoCadena}");
        }
    }
}
