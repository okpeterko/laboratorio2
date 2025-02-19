using System;

class Program
{
    static void Main()
    {
        // Solicitar números enteros
        Console.Write("Ingrese el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Operaciones matemáticas con enteros
        Console.WriteLine($"\nOperaciones con int:");
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {(num2 != 0 ? (num1 / (double)num2) : "Indefinido (división por cero)")}");

        // Solicitar números decimales
        Console.Write("\nIngrese el primer número decimal: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número decimal: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        // Operaciones matemáticas con double
        Console.WriteLine($"\nOperaciones con double:");
        Console.WriteLine($"{num3} + {num4} = {num3 + num4}");
        Console.WriteLine($"{num3} - {num4} = {num3 - num4}");
        Console.WriteLine($"{num3} * {num4} = {num3 * num4}");
        Console.WriteLine($"{num3} / {num4} = {(num4 != 0 ? (num3 / num4) : "Indefinido (división por cero)")}");

        // Operaciones con float
        Console.Write("\nIngrese el primer número flotante: ");
        float num5 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Ingrese el segundo número flotante: ");
        float num6 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine($"\nOperaciones con float:");
        Console.WriteLine($"{num5} + {num6} = {num5 + num6}");
        Console.WriteLine($"{num5} - {num6} = {num5 - num6}");
        Console.WriteLine($"{num5} * {num6} = {num5 * num6}");
        Console.WriteLine($"{num5} / {num6} = {(num6 != 0 ? (num5 / num6) : "Indefinido (división por cero)")}");

        // Operaciones con Int16
        Console.Write("\nIngrese el primer número (Int16): ");
        short num7 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Ingrese el segundo número (Int16): ");
        short num8 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"\nOperaciones con Int16:");
        Console.WriteLine($"{num7} + {num8} = {num7 + num8}");
        Console.WriteLine($"{num7} - {num8} = {num7 - num8}");
        Console.WriteLine($"{num7} * {num8} = {num7 * num8}");
        Console.WriteLine($"{num7} / {num8} = {(num8 != 0 ? (num7 / (double)num8) : "Indefinido (división por cero)")}");

        // Operaciones con byte
        Console.Write("\nIngrese el primer número (byte): ");
        byte num9 = Convert.ToByte(Console.ReadLine());

        Console.Write("Ingrese el segundo número (byte): ");
        byte num10 = Convert.ToByte(Console.ReadLine());

        Console.WriteLine($"\nOperaciones con byte:");
        Console.WriteLine($"{num9} + {num10} = {num9 + num10}");
        Console.WriteLine($"{num9} - {num10} = {num9 - num10}");
        Console.WriteLine($"{num9} * {num10} = {num9 * num10}");
        Console.WriteLine($"{num9} / {num10} = {(num10 != 0 ? (num9 / (double)num10) : "Indefinido (división por cero)")}");
    }
}
