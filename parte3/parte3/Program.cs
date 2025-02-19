using System;

class Program
{
    static void Main()
    {
        // Solicitar dos números al usuario
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Comparaciones básicas
        Console.WriteLine($"\nComparaciones:");
        Console.WriteLine($"{num1} > {num2}  →  {num1 > num2}");
        Console.WriteLine($"{num1} < {num2}  →  {num1 < num2}");
        Console.WriteLine($"{num1} == {num2} →  {num1 == num2}");

        // Operaciones lógicas con AND (&&) y OR (||)
        Console.WriteLine($"\nOperaciones Lógicas:");
        Console.WriteLine($"({num1} > 0) && ({num2} > 0)  →  {(num1 > 0 && num2 > 0)}");  // Ambos son positivos
        Console.WriteLine($"({num1} < 0) || ({num2} < 0)  →  {(num1 < 0 || num2 < 0)}");  // Al menos uno es negativo

        // Otra expresión combinada
        Console.WriteLine($"(({num1} % 2 == 0) && ({num2} % 2 == 0))  →  {(num1 % 2 == 0 && num2 % 2 == 0)}"); // Ambos son pares
    }
}
