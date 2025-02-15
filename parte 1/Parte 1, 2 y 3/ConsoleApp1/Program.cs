using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            // Declaración de variables
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            // Solicitar valores al usuario
            Console.Write("Ingrese un número entero: ");
            numeroEntero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un número decimal: ");
            numeroDecimal = double.Parse(Console.ReadLine());

            Console.Write("Ingrese un texto: ");
            texto = Console.ReadLine();

            Console.Write("Ingrese un valor verdadero o falso (1 es verdad, 0 es falso): ");
            string entrada = Console.ReadLine().ToLower();
            valorBooleano = entrada == "1";

            // Mostrar los valores ingresados
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine($"Número entero: {numeroEntero}");
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Valor booleano: {valorBooleano}");

            // Operaciones con diferentes tipos de datos
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOperaciones con int:");
            Console.WriteLine($"Suma: {num1 + num2}");
            Console.WriteLine($"Resta: {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1 * num2}");
            Console.WriteLine($"División: {(num2 != 0 ? (num1 / (double)num2) : "Indefinida")}");

            Console.Write("Ingrese el primer número decimal: ");
            float num3 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número decimal: ");
            float num4 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nOperaciones con float:");
            Console.WriteLine($"Suma: {num3 + num4}");
            Console.WriteLine($"Resta: {num3 - num4}");
            Console.WriteLine($"Multiplicación: {num3 * num4}");
            Console.WriteLine($"División: {(num4 != 0 ? (num3 / num4) : "Indefinida")}");

            Console.Write("Ingrese el primer número Int16: ");
            short num5 = short.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número Int16: ");
            short num6 = short.Parse(Console.ReadLine());

            Console.WriteLine("\nOperaciones con Int16:");
            Console.WriteLine($"Suma: {num5 + num6}");
            Console.WriteLine($"Resta: {num5 - num6}");
            Console.WriteLine($"Multiplicación: {num5 * num6}");
            Console.WriteLine($"División: {(num6 != 0 ? (num5 / (double)num6) : "Indefinida")}");

            Console.Write("Ingrese el primer número Byte: ");
            byte num7 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número Byte: ");
            byte num8 = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nOperaciones con Byte:");
            Console.WriteLine($"Suma: {num7 + num8}");
            Console.WriteLine($"Resta: {num7 - num8}");
            Console.WriteLine($"Multiplicación: {num7 * num8}");
            Console.WriteLine($"División: {(num8 != 0 ? (num7 / (double)num8) : "Indefinida")}");

            // Comparaciones con operadores lógicos
            Console.Write("Ingrese el primer valor para comparaciones: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor para comparaciones: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nComparaciones:");
            Console.WriteLine($"{valor1} > {valor2}: {valor1 > valor2}");
            Console.WriteLine($"{valor1} < {valor2}: {valor1 < valor2}");
            Console.WriteLine($"{valor1} == {valor2}: {valor1 == valor2}");

            Console.WriteLine("\nOperadores lógicos:");
            Console.WriteLine($"({valor1} > {valor2}) && ({valor1} == {valor2}): {(valor1 > valor2) && (valor1 == valor2)}");
            Console.WriteLine($"({valor1} > {valor2}) || ({valor1} == {valor2}): {(valor1 > valor2) || (valor1 == valor2)}");

            // Evitar que la consola se cierre automáticamente
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
