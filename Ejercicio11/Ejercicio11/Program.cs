using System;

namespace CompararNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double numero1 = 10; 
            double numero2 = 15; 
            
            if (numero1 > numero2)
            {
                Console.WriteLine($"El número {numero1} es mayor que {numero2}.");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"El número {numero2} es mayor que {numero1}.");
            }
            else
            {
                Console.WriteLine($"Los números {numero1} y {numero2} son iguales.");
            }
        }
    }
}
