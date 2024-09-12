using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var calificaciones = new List<double>();

        Console.Write("Ingrese el número de calificaciones: ");
        int numCalificaciones = int.Parse(Console.ReadLine());

        for (int i = 0; i < numCalificaciones; i++)
        {
            Console.Write($"Calificación {i + 1}: ");
            double calificacion = double.Parse(Console.ReadLine());
            calificaciones.Add(calificacion);
        }
        double promedio = calificaciones.Average();
        Console.WriteLine($"Promedio: {promedio:F2}");
    }
}
