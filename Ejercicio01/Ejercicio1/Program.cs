using System;

namespace SumaDeTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.5;
            double num2 = 20.5;
            double num3 = 30.5;

            double suma = num1 + num2 + num3;

            Console.WriteLine($"La suma de {num1}, {num2} y {num3} es: {suma}");
        }
    }
}