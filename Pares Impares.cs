using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class Pares 
    {
            public static void Main(string[] args)
            {
                // Pedir la cantidad de números al usuario
                Console.Write("Introduce la cantidad de números que deseas ingresar: ");
                int cantidadNumeros = int.Parse(Console.ReadLine());

                // Variables para contar pares e impares
                int cantidadPares = 0;
                int cantidadImpares = 0;

                // Variables para sumar pares e impares
                int sumaPares = 0;
                int sumaImpares = 0;

                // Pedir cada número al usuario
                for (int i = 0; i < cantidadNumeros; i++)
                {
                    Console.Write($"Introduce el número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());

                    // Contar pares e impares
                    if (numero % 2 == 0)
                    {
                        cantidadPares++;
                        sumaPares += numero;
                    }
                    else
                    {
                        cantidadImpares++;
                        sumaImpares += numero;
                    }
                }

                // Mostrar resultados
                Console.WriteLine($"\nCantidad de números pares: {cantidadPares}");
                Console.WriteLine($"Cantidad de números impares: {cantidadImpares}");
                Console.WriteLine($"Suma de números pares: {sumaPares}");
                Console.WriteLine($"Suma de números impares: {sumaImpares}");
            }
        }
    }
