using System;

namespace SaludoPersonalizadoInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Bienvenido {nombre}");
        }
    }
}
