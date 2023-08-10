using System;

namespace SumaDeVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de ventas que deseas registrar:");

            int numVentas;
            while (!int.TryParse(Console.ReadLine(), out numVentas) || numVentas < 1)
            {
                Console.WriteLine("Por favor, introduce un número válido de ventas:");
            }

            double sumaTotal = 0;

            for (int i = 1; i <= numVentas; i++)
            {
                Console.WriteLine($"Introduce el valor de la venta {i}:");

                double valorVenta;
                while (!double.TryParse(Console.ReadLine(), out valorVenta) || valorVenta < 0)
                {
                    Console.WriteLine($"Por favor, introduce un valor válido para la venta {i}:");
                }

                sumaTotal += valorVenta;
            }

            Console.WriteLine($"El total de las ventas es: {sumaTotal}");
        }
    }
}