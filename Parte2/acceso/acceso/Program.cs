using System;

class Program
{
    static void Main()
    {
        // Definir credenciales correctas
        string usuarioCorrecto = "Jose";
        string contraseñaCorrecta = "progra1";

        // Solicita el nombre de usuario y contraseña
        Console.Write("Ingrese su nombre de usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contraseña = Console.ReadLine();

        // Verifica las credenciales usando if-else
        if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
        {
            Console.WriteLine("Bienvenido");
        }
        else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}
