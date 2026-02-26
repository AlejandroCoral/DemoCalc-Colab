// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Menu Version 1");
Console.WriteLine("Cambios realizados desde Visual Studio .NET");
Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"¡Hola {nombre}! DemoCalc lista.");
Console.ResetColor();

Console.WriteLine("   SISTEMA DE CÁLCULO - DEMOCALC   ");
Console.WriteLine("Versión: 1.1");
Console.WriteLine($"Fecha y hora de inicio: {DateTime.Now}");
Console.WriteLine();
Console.WriteLine("Cambios sincronizados desde Visual Studio .NET");
Console.WriteLine("Repositorio actualizado correctamente");