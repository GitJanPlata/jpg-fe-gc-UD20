using System;

namespace ComprobacionContraseña
{
    class Program
    {
        static void Main(string[] args)
        {
            const string contraseña = "12345"; 
            int intentos = 3;

            while (intentos > 0)
            {
                Console.WriteLine("Introduce la contraseña:");
                string entrada = Console.ReadLine();

                if (entrada == contraseña)
                {
                    Console.WriteLine("Enhorabuena");
                    break;
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                    {
                        Console.WriteLine($"Contraseña incorrecta. Te quedan {intentos} intentos.");
                    }
                    else
                    {
                        Console.WriteLine("Has agotado todos tus intentos.");
                    }
                }
            }
        }
    }
}
