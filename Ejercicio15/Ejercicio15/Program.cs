using System;

namespace DivisiblePorDos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Introduce un número:");
            double numero;

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, introduce un número válido:");
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es divisible entre 2.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es divisible entre 2.");
            }
        }
    }
}
