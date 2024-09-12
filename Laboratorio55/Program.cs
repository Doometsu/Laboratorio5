using System;
using System.Collections.Generic;

class Program
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Estudiante(string nombre, int edad) { Nombre = nombre; Edad = edad; }
    }

    static void Main()
    {
        var estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana", 20),
            new Estudiante("Luis", 22),
            new Estudiante("Marta", 19)
        };

        estudiantes.ForEach(e => Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}"));
    }
}
