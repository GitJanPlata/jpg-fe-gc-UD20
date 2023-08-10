using System;

namespace PrecioConIVA
{
    class Program
    {
        static void Main(string[] args)
        {
            const double IVA = 0.21;

            Console.WriteLine("Introduce el precio del producto:");
            double precioSinIVA;

            while (!double.TryParse(Console.ReadLine(), out precioSinIVA) || precioSinIVA < 0)
            {
                Console.WriteLine("Por favor, introduce un precio válido:");
            }

            double precioConIVA = precioSinIVA + (precioSinIVA * IVA);

            Console.WriteLine($"El precio del producto sin IVA es: {precioSinIVA}");
            Console.WriteLine($"El precio del producto con IVA del 21% es: {precioConIVA}");
        }
    }
}
