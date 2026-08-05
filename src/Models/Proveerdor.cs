namespace InventarioApp.src.models
{
    // Record 
    // Inmutable 
    public record Proveedor(
        int Id,
        string Nombre,
        string Email,
        string Telefono);
}