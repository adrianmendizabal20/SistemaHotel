using System;

class Program
{
    // Método que calcula el costo total del hospedaje
    static double CalcularCosto(double precioNoche, int noches)
    {
        return precioNoche * noches;
    }

    static void Main(string[] args)
    {
        // Solicitar precio por noche
        Console.Write("Ingrese el precio por noche: ");
        double precioNoche = Convert.ToDouble(Console.ReadLine());

        // Solicitar cantidad de noches
        Console.Write("Ingrese la cantidad de noches: ");
        int noches = Convert.ToInt32(Console.ReadLine());

        // Llamar al método y enviar parámetros
        double total = CalcularCosto(precioNoche, noches);

        // Mostrar resultado
        Console.WriteLine("Costo total de hospedaje: S/ " + total);

        Console.ReadKey();
    }
}
