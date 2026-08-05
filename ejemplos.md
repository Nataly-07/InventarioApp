tipoRetorno     NombreMetodo (tipo parametro1, tipo parametro2){ //Parametros son datos que el metodo recibe
    cuerpo
    return
}

scope de varibales?

Cada metodo tiene su propio scope
las variables dentro de un método no existen en otro -> Seguridad

las avriables no curzan fronteras 

//Clases
class Prodcto
{
    // get = Obtener el valor de la variable
    // set para Sobreescribir el valor de la Variable
    //Cada variable debe llevar  van dentro de {} 


    public int Id { get; set;}
    public string Nombre { get; set; } = "";
    public decimal Precio { get; set; }
}


// Strings   | Enums

// sin enum 
**      **

// 
// PROBLEMA: Uso de cadenas de texto (strings) sin tipado fuerte
// 
// Al usar simples textos para clasificar o representar categorías:
string categoria = "electronica"; // Minúscula
string otra = "ELECTRONICA";      // Mayúscula

// El compilador acepta ambos valores como cadenas válidas sin mostrar errores.
// Sin embargo, en tiempo de ejecución (runtime) causarán fallos o inconsistencias
// al comparar o filtrar datos (por ejemplo: "electronica" != "ELECTRONICA").


// 
// SOLUCIÓN: Uso de un tipo enumerado (enum) fuertemente tipado
// 

// Define un conjunto cerrado y seguro de opciones permitidas en todo el sistema.
public enum CategoriaProducto
{
    Electronica, // Asignado automáticamente al entero 0
    Ropa,        // Asignado automáticamente al entero 1
    Alimentos,   // Asignado automáticamente al entero 2
    Hogar,       // Asignado automáticamente al entero 3
    Otros        // Asignado automáticamente al entero 4
}


// 
// VENTAJAS PRÁCTICAS
// 
// Se fuerza el uso de un valor estricto asignando la propiedad desde el enum:

var producto = new Producto { Categoria = CategoriaProducto.Electronica };

// 1. Autocompletado (IntelliSense): El IDE sugiere solo las opciones válidas definidas en el enum.
// 2. Seguridad en compilación: Si cometes un error tipográfico, el compilador lo detecta de inmediato.
// 3. Mantenibilidad: Previene inconsistencias como diferencias entre mayúsculas y minúsculas.


//***************

Tipos de Datos que no debrian cambiar: ej nombre del producto

records   : son como Clases pero Inmutables 


// Clases unifican datos relacionados, pueden tener get para obtener la infor del dato y set para sobreescribirla 

Propiedades calculadas con lambda no tienen get ni set 

Enum seguran valores validos 

Record -> Clases inmutables para datos fijos 

//*********************

PRODUCTO.CS:

//Las variables reciben cualquier tipo de Dato 

ANTES                                  vs       DESPUÉS
public string Nombre { get; set; }              //campo privado + setter con guard
public decimal Precio { get; set; }             //setter con validacion
public int Cantidad { get; set; }               //setter con validacion


//Eliminar codigo hace parte de refactorizar -> mejorar codigo sin cambiar comportamiento 


GUARD CLAUSES 
Validación temprana que falla rapido. 
Si los datos son invalidos, lanza una excepcion inmediatamente. 


//Principio fail Fast: falla temprano, falla claro 


/// Clase 13

// guard clause (mal implementado):
void ProcesarPago(decimal monto)
{
    // ... 100 líneas de lógica ...
    if (monto <= 0) // Validar al final
    {
        throw new ArgumentException("Monto inválido");
    }
}

// CON guard clause (implementado correctamente):
void ProcesarPago(decimal monto)
{
    if (monto <= 0) // Validar PRIMERO
        throw new ArgumentException("Monto inválido");
    // ... 100 líneas de lógica conforme a que monto es válido ...
}

// Guard clause = Fail Fast
// Falla temprano, evita procesamiento innecesario

//Rechazar datos invalidos inmediatamente 



//Sub Carpeta Factories  -> Es un patrón que centraliza la creación de Objetos. 
Un solo luegar para validación, IDs y lógica de contrucción 


// Guard Clause 
Validar 
lanzar si falla
asiganr si pasa 
