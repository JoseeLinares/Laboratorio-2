using System;

class Program
{
    static void Main()
    {
        // Solicita la edad al usuario
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        // Determina la categoría según la edad usando if-else
        if (edad < 12)
        {
            Console.WriteLine("Categoría: Niño");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Categoría: Adolescente");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("Categoría: Adulto");
        }
        else
        {
            Console.WriteLine("Categoría: Adulto mayor");
        }
    }
}
