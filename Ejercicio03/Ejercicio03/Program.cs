using System;

namespace NombreYEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor, introduce tu edad:");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Por favor, introduce una edad válida:");
            }

            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años.");
        }
    }
}
