namespace InventarioApp.Models;

// Comentarios XML

/// <summary>
/// Ciclo de vida de un producto en el inventario.
/// </summary>
public enum EstadoProducto
//Palabra reservada enum: son conjusntos de constantes con nombre.
// Tiene 3 valores Fijos

{
    /// <summary>Disponible para venta.</summary>
    Activo,

    /// <summary>Temporalmente fuera de disponibilidad.</summary>
    Inactivo,

    /// <summary>Retirado permanentemente del catalogo.</summary>
    Descontinuado
    
}