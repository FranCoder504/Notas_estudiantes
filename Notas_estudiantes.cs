using System;
using System.Collections.Generic;
using System.Linq;

public class NotasEstudiantes
{
    public static void Main()
    {
        List<double> notas = new List<double>();
        string input;

        Console.WriteLine("Ingresa las notas del estudiante (escribe 'fin' para terminar):");
        while ((input = Console.ReadLine()) != "fin")
        {
            if (double.TryParse(input, out double nota) && nota >= 0)
                notas.Add(nota);
            else
                Console.WriteLine(" Ingresa un número válido.");
        }

        if (notas.Count == 0)
        {
            Console.WriteLine("No se ingresaron notas.");
            return;
        }

        double promedio = notas.Average();
        Console.WriteLine($"\nTotal de notas: {notas.Count}");
        Console.WriteLine($"Promedio: {promedio:F2}");
    }
}
