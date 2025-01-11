using System;
using System.Collections.Generic;

namespace InterfazGenerica
{
    public interface IContenedor<T>
    {
        void Agregar(T elemento); 
        T Obtener(int indice);
    }
    public class Caja<T> : IContenedor<T>
    {
        private List<T> elementos;

        public Caja()
        {
            elementos = new List<T>();
        }

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
            Console.WriteLine($"{elemento} ha sido agregado a la caja.");
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
            IContenedor<int> cajaEnteros = new Caja<int>();
            cajaEnteros.Agregar(10);
            cajaEnteros.Agregar(20);
            cajaEnteros.Agregar(30);
            Console.WriteLine($"Elemento obtenido: {cajaEnteros.Obtener(1)}");

            ((Caja<int>)cajaEnteros).MostrarElementos();
            IContenedor<string> cajaCadenas = new Caja<string>();
            cajaCadenas.Agregar("Hola");
            cajaCadenas.Agregar("Mundo");

            Console.WriteLine($"Elemento obtenido: {cajaCadenas.Obtener(0)}");
            ((Caja<string>)cajaCadenas).MostrarElementos();
        }
    }
}
