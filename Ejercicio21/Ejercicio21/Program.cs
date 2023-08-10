using System;

namespace DiaLaboral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un día de la semana (lunes, martes, etc.):");
            string dia = Console.ReadLine().ToLower(); 

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine($"El {dia} es un día laboral.");
                    break;
                case "sábado":
                case "domingo":
                    Console.WriteLine($"El {dia} no es un día laboral.");
                    break;
                default:
                    Console.WriteLine("No has introducido un día válido.");
                    break;
            }
        }
    }
}
