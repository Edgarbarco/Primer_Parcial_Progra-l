using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
    public class Calculadora
{ 
    public static void Main(string[] args)
    {
        double num1, num2, resultado;
        string operacion;

        Console.Write("Introduce el primer número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nElige una operación:");
        Console.WriteLine("1. Suma (+) ");
        Console.WriteLine("2. Resta (-) ");
        Console.WriteLine("3. Multiplicación (*) ");
        Console.WriteLine("4. División (/) ");
        Console.Write("Opción: ");

        operacion = Console.ReadLine();

        switch (operacion)
        {
            case "+":
                resultado = num1 + num2;
                Console.WriteLine("\n{0} + {1} = {2}", num1, num2, resultado);
                break;
            case "-":
                resultado = num1 - num2;
                Console.WriteLine("\n{0} - {1} = {2}", num1, num2, resultado);
                break;
            case "*":
                resultado = num1 * num2;
                Console.WriteLine("\n{0} * {1} = {2}", num1, num2, resultado);
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("\nError: No se puede dividir por 0.");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("\n{0} / {1} = {2}", num1, num2, resultado);
                }
                break;
            default:
                Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
                break;
        }
    }

}