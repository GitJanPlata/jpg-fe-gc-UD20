using System;

namespace CalculadoraInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer operando (número entero):");
            if (!int.TryParse(Console.ReadLine(), out int operando1))
            {
                Console.WriteLine("Entrada no válida.");
                return;
            }

            Console.WriteLine("Introduce el segundo operando (número entero):");
            if (!int.TryParse(Console.ReadLine(), out int operando2))
            {
                Console.WriteLine("Entrada no válida.");
                return;
            }

            Console.WriteLine("Introduce un signo aritmético (+, -, *, /, ^, %):");
            string signo = Console.ReadLine();

            double resultado;

            switch (signo)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    if (operando2 == 0)
                    {
                        Console.WriteLine("División por cero no permitida.");
                        return;
                    }
                    resultado = (double)operando1 / operando2;
                    break;
                case "^":
                    resultado = Math.Pow(operando1, operando2);
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
                default:
                    Console.WriteLine("Signo aritmético no válido.");
                    return;
            }
             Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
