// Console.WriteLine("Hello, World!");



using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;


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
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuración e Repositorio en GitHub");
