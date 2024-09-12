using System;

namespace SueldosOperarios
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] sueldos = new decimal[5];

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write($"Ingrese el sueldo del operario {i + 1}: ");

                while (true)
                {
                    string entrada = Console.ReadLine();

                    if (decimal.TryParse(entrada, out decimal sueldo))
                    {
                        sueldos[i] = sueldo;
                        break;
                    }
                    else
                    {
                        Console.Write("Entrada no válida. Por favor, ingrese un sueldo válido: ");
                    }
                }
            }
            Console.WriteLine("\nSueldos ingresados:");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine($"Sueldo del operario {i + 1}: {sueldos[i]:C}");
            }
        }
    }
}
