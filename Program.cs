// Console.WriteLine("Hello, World!");


using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

// Manejo de Argumentos
if (args.Length >0)
{
    switch (args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;

        case "--version":
            Console.WriteLine($"InventarioApp v[{version}]");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine($"Error: Comando desconocido '{args[0]}'");
            Console.WriteLine("Use --help para ver los comandos disponibles. ");
            Environment.Exit(1);
            break;

    }
}

Console.WriteLine("");
Console.WriteLine("     SISTEMA DE GESTIÓN DE INVENTARIO       ");
Console.WriteLine("");
Console.WriteLine();

Console.WriteLine($"Versión: {version}");

// Console.WriteLine($"Versión: 1.0.0");
Console.WriteLine($"Platafroma: {Environment.OSVersion}");
Console.WriteLine($".NET Versión: {Environment.Version}");
// Console.WriteLine();
// Console.WriteLine("Estado: Proyecto inicializao");

Console.WriteLine();
Console.WriteLine("Estructura del Proyecto");

Console.WriteLine("  InventarioApp/");
Console.WriteLine("    |-- Program.cs");
Console.WriteLine("    |-- InevntarioApp.csproj");
Console.WriteLine("    |-- .gitignore");
Console.WriteLine("    |-- README.md");
Console.WriteLine("    |-- src/");
Console.WriteLine("         |-- Models/ ");

Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Checkpoint");


//Funciones
void MostrarBanner ()
{
    
}

// Función 

void MostrarAyuda ()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");

}