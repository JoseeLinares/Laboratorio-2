using System;

class Program
{
    static void Main()
    {
        // Solicita un número del 1 al 7
        Console.Write("Ingrese un número (1-7) para obtener el día de la semana: ");
        int dia = int.Parse(Console.ReadLine());

        // Determina el día de la semana usando switch
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
                Console.WriteLine("Número inválido, debe ser entre 1 y 7.");
                break;
        }
    }
}

