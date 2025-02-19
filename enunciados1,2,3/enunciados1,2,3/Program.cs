using System;

class Program
{
    static void Main()
    {
        ClasificacionEdad();
        DiaDeLaSemana();
        VerificacionDeAcceso();
    }

    static void ClasificacionEdad()
    {
        Console.WriteLine("=== Clasificación de Edad ===");
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 12)
        {
            Console.WriteLine("Niño");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Adulto mayor");
        }
        Console.WriteLine();
    }

    static void DiaDeLaSemana()
    {
        Console.WriteLine("=== Día de la Semana ===");
        Console.Write("Ingresa un número del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número inválido. Ingresa un número del 1 al 7.");
                break;
        }
        Console.WriteLine();
    }

    static void VerificacionDeAcceso()
    {
        Console.WriteLine("=== Verificación de Acceso ===");
        string usuarioCorrecto = "usuario123";
        string contrasenaCorrecta = "clave123";

        Console.Write("Ingresa tu nombre de usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Ingresa tu contraseña: ");
        string contrasena = Console.ReadLine();

        if (usuario == usuarioCorrecto)
        {
            if (contrasena == contrasenaCorrecta)
            {
                Console.WriteLine("Acceso concedido");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}
