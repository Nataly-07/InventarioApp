// using InventarioApp.Models;
// using InventarioApp.src.models;

// namespace InventarioApp.Repositories;



// public class InMemoryProductoRepository : IProductoRepository
// {
//     private readonly List<Producto> _productos = new();
//     private int _proximoId = 1;

//     public void Agregar(Producto producto)
//     {
//         producto.Id = _proximoId++;
//         _productos.Add(producto);   //Esta operación lo q hace es modificar la colección interna. Por eso no retorna nada
//     }

//     public Producto? ObtenerPorId(int id)
//     {
//         return _productos.FirstOrDefault(p => p.Id == id);
//     }

//     public IEnumerable<Producto> ObtenerTodos()
//     {
//         return _productos.AsReadOnly(); //-> convierte la lista mutable en una colección de solo lectura 
//     }

//     public bool Actualizar(Producto producto)
//     {
//         var existente = ObtenerPorId(producto.Id);
//         if (existente == null) return false;

//         existente.Nombre = producto.Nombre;
//         existente.Precio = producto.Precio;
//         existente.Cantidad = producto.Cantidad;
//         existente.Categoria = producto.Categoria;
//         existente.Estado = producto.Estado;

//         return true;
//     }

//     public bool Eliminar(int id)
//     {
//         var producto = ObtenerPorId(id);
//         if (producto == null) return false;

//         return _productos.Remove(producto);
//     }

//     public int Cantidad => _productos.Count;


// //LINQ 
// //Se expresa directamente la intentción. 
// //Filtramos la colección inicando el criterio sin preocupacion por el Recorrido elemento por elemento
// //where


//     //======== Busquedas con Where LINQ ========

// public IEnumerable<Producto> BuscarPorCategoria(CategoriaProducto categoria)
// {
//     return _productos.Where(p => p.Categoria == categoria);
// }
// // Where es el equivalente en linq de un filtro SQL where 

// public IEnumerable<Producto> BuscarPorNombre(string nombre)
// {
//     return _productos.Where(p => p.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
// }

// public IEnumerable<Producto> BuscarPorRangoPrecio(decimal precioMinimo, decimal precioMaximo)
// {
//     return _productos.Where(p => p.Precio >= precioMinimo && p.Precio <= precioMaximo);
// }

// //== Select y Any =====

// public IEnumerable<string> ObtenerNombres()
// {
//     return _productos.Select(p => p.Nombre);
// }

// public bool HayStockBajo()
// {
//     return _productos.Any(p => p.Cantidad < 5);
// }

// //Select cambia la forma dle resultado y any responde a una pregunta Booleana 


// //Ordenar Datos

// public IEnumerable<Producto> ObtenerOrdenadosPorPrecio()
// {
//     return _productos.OrderBy(p => p.Precio); //OrderBy organiza la coleccion
// }

// public IEnumerable<Producto> ObtenerTopPorPrecio(int cantidad)
// {
//     return _productos.OrderByDescending(p => p.Precio).Take(cantidad);  //Take Limita el =
// }


// //Agrupar datos

// //======= GropuBy y conversion a Dictionary. ========

// public IEnumerable<IGrouping<CategoriaProducto, Producto>> AgruparPorCategoria()
// {
//     return _productos.GroupBy(p => p.Categoria);
// }

// public Dictionary<CategoriaProducto, int> ContarPorCategoria()
// {
//     return _productos // List<Producto>
//         .GroupBy(p => p.Categoria) // IEnumerable<IGrouping<...>>
//         .ToDictionary(g => g.Key, g => g.Count());
// }

// // Agregaciones con Sum, Avegarge y MaxBy

// public decimal ObtenerValorTotalInventario()
// {
//     return _productos.Sum(p => p.ValorTotal);
// }

// public decimal ObtenerPrecioPromedio()
// {
//     if (_productos.Count == 0) return 0;
//     return _productos.Average(p => p.Precio);
// }

// public Producto? ObtenerProductoMasCaro()
// {
//     return _productos.MaxBy(p => p.Precio);
// }

// // Sum y Average devuelven npumeros y MaxBy devuelve el objeto completo, no solo el valor max

//  //LINQ -> La Fortaleza esta en el encadenamiento 

//  //Filtrados por catgeoria

//  public Dictionary<CategoriaProducto, decimal> ObtenerValorPorCategoria()
// {
//     return _productos // List<Producto>
//         .GroupBy(p => p.Categoria) // IEnumerable<IGrouping<...>>
//         .ToDictionary(g => g.Key, g => g.Sum(p => p.ValorTotal));
// }

//     public void Agregar(Producto producto)
//     {
//         throw new NotImplementedException();
//     }

//     Producto? IProductoRepository.ObtenerPorId(int id)
//     {
//         throw new NotImplementedException();
//     }

//     IEnumerable<Producto> IProductoRepository.ObtenerTodos()
//     {
//         throw new NotImplementedException();
//     }

//     public bool Actualizar(Producto producto)
//     {
//         throw new NotImplementedException();
//     }
// }




using InventarioApp.Models;
using InventarioApp.src.models;

namespace InventarioApp.Repositories;

public class InMemoryProductoRepository : IProductoRepository
{
    private readonly List<Producto> _productos = new();
    private int _proximoId = 1;

    public void Agregar(Producto producto)
    {
        producto.Id = _proximoId++;
        _productos.Add(producto);
    }

    public Producto? ObtenerPorId(int id)
    {
        return _productos.FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<Producto> ObtenerTodos()
    {
        return _productos.AsReadOnly();
    }

    public bool Actualizar(Producto producto)
    {
        var existente = ObtenerPorId(producto.Id);

        if (existente == null)
            return false;

        existente.Nombre = producto.Nombre;
        existente.Precio = producto.Precio;
        existente.Cantidad = producto.Cantidad;
        existente.Categoria = producto.Categoria;
        existente.Estado = producto.Estado;

        return true;
    }

    public bool Eliminar(int id)
    {
        var producto = ObtenerPorId(id);

        if (producto == null)
            return false;

        return _productos.Remove(producto);
    }

    public int Cantidad => _productos.Count;

    // ==================== BÚSQUEDAS ====================

    public IEnumerable<Producto> BuscarPorCategoria(CategoriaProducto categoria)
    {
        return _productos.Where(p => p.Categoria == categoria);
    }

    public IEnumerable<Producto> BuscarPorNombre(string nombre)
    {
        return _productos.Where(p =>
            p.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Producto> BuscarPorRangoPrecio(decimal precioMinimo, decimal precioMaximo)
    {
        return _productos.Where(p =>
            p.Precio >= precioMinimo &&
            p.Precio <= precioMaximo);
    }

    // ==================== SELECT Y ANY ====================

    public IEnumerable<string> ObtenerNombres()
    {
        return _productos.Select(p => p.Nombre);
    }

    public bool HayStockBajo()
    {
        return _productos.Any(p => p.Cantidad < 5);
    }

    // ==================== ORDENAMIENTO ====================

    public IEnumerable<Producto> ObtenerOrdenadosPorPrecio()
    {
        return _productos.OrderBy(p => p.Precio);
    }

    public IEnumerable<Producto> ObtenerTopPorPrecio(int cantidad)
    {
        return _productos
            .OrderByDescending(p => p.Precio)
            .Take(cantidad);
    }

    // ==================== AGRUPACIONES ====================

    public IEnumerable<IGrouping<CategoriaProducto, Producto>> AgruparPorCategoria()
    {
        return _productos.GroupBy(p => p.Categoria);
    }

    public Dictionary<CategoriaProducto, int> ContarPorCategoria()
    {
        return _productos
            .GroupBy(p => p.Categoria)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    public Dictionary<CategoriaProducto, decimal> ObtenerValorPorCategoria()
    {
        return _productos
            .GroupBy(p => p.Categoria)
            .ToDictionary(
                g => g.Key,
                g => g.Sum(p => p.ValorTotal)
            );
    }

    // ==================== AGREGACIONES ====================

    public decimal ObtenerValorTotalInventario()
    {
        return _productos.Sum(p => p.ValorTotal);
    }

    public decimal ObtenerPrecioPromedio()
    {
        if (!_productos.Any())
            return 0;

        return _productos.Average(p => p.Precio);
    }

    public Producto? ObtenerProductoMasCaro()
    {
        return _productos.MaxBy(p => p.Precio);
    }
}

