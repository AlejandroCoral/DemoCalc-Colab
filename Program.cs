// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Menu Version 1");
Console.WriteLine("Cambios realizados desde Visual Studio .NET");

Console.WriteLine("SISTEMA DE CALCULO");
Console.WriteLine("Version:1.1");
Console.WriteLine($"Fecha y hora de incio: {DateTime.Now}");
Console.WriteLine();
Console.WriteLine("Cambios sincronizados desde Visual Studio .NET");
Console.WriteLine("Reositorio actualizado correctamente");

Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hola " + nombre);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("presiona cualquier tecla para salir de democalc..");
Console.ResetColor();
Console.ReadKey();
