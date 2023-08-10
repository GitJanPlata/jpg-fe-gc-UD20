using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio del círculo:");
            double radio;

            while (!double.TryParse(Console.ReadLine(), out radio) || radio < 0)
            {
                Console.WriteLine("Por favor, introduce un valor válido para el radio:");
            }

            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
        }
    }
}
