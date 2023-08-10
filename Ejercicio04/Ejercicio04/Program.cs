using System;

namespace NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número:");
            double numero1;
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Por favor, introduce un número válido:");
            }

            Console.WriteLine("Introduce el segundo número:");
            double numero2;
            while (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Por favor, introduce un número válido:");
            }

            if (numero1 > numero2)
            {
                Console.WriteLine($"El número {numero1} es el mayor.");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El número {numero2} es el mayor.");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
    }
}
