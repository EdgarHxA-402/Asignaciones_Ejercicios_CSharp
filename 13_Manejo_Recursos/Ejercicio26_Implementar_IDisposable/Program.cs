using System;

namespace EjemploIDisposable
{
    public class Recurso : IDisposable
    {
        private bool _recursoLiberado = false;
        public Recurso()
        {
            Console.WriteLine("Recurso creado.");
        }

        public void Dispose()
        {
            LiberarRecursos(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void LiberarRecursos(bool disposing)
        {
            if (!_recursoLiberado)
            {
                if (disposing)
                {
                    Console.WriteLine("Liberando recursos administrados...");
                }

                Console.WriteLine("Liberando recursos no administrados...");
                _recursoLiberado = true;
            }
        }
        ~Recurso()
        {
            LiberarRecursos(false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var recurso = new Recurso())
            {
                Console.WriteLine("Usando el recurso...");
            }

            Console.WriteLine("El recurso fue liberado.");
        }
    }
}
