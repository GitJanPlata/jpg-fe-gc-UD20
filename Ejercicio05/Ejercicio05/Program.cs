using System;

namespace DiaDeLaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre del día de la semana:");
            string dia = Console.ReadLine().ToLower();  // Convertir a minúsculas para facilitar la comparación

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miercoles": 
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana.");
                    break;

                case "sabado":  
                case "domingo":
                    Console.WriteLine("Es fin de semana.");
                    break;

                default:
                    Console.WriteLine("Error: El nombre introducido no corresponde a un día de la semana válido.");
                    break;
            }
        }
    }
}