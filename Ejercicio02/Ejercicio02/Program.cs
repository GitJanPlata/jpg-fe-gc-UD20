using System;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor, introduce el nombre de una ciudad:");
            string ciudad = Console.ReadLine();

            Console.WriteLine($"Hola {nombre}, bienvenido a {ciudad}");
        }
    }
}