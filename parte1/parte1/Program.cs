using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        // Solicitar y leer valores desde el teclado
        Console.Write("Ingrese un número entero: ");
        numeroEntero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un número decimal: ");
        numeroDecimal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingrese un valor verdadero o falso (true/false): ");
        valorBooleano = Convert.ToBoolean(Console.ReadLine());

        // Mostrar los valores ingresados
        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine($"Número entero: {numeroEntero}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor booleano: {valorBooleano}");
    }
}
