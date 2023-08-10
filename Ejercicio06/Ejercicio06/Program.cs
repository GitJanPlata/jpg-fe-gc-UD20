using System;

namespace FormaDePago
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio del producto:");
            decimal precio;
            while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.WriteLine("Por favor, introduce un valor positivo válido para el precio:");
            }

            Console.WriteLine("¿Cuál es la forma de pago? (efectivo/tarjeta)");
            string formaPago = Console.ReadLine().ToLower();

            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Introduce el número de cuenta (inventado):");
                string numeroCuenta = Console.ReadLine(); 
                Console.WriteLine($"Se procesará el pago de {precio} mediante la tarjeta con número de cuenta: {numeroCuenta}");
            }
            else if (formaPago == "efectivo")
            {
                Console.WriteLine($"Se procesará el pago de {precio} en efectivo.");
            }
            else
            {
                Console.WriteLine("Error: Forma de pago no reconocida.");
            }
        }
    }
}
