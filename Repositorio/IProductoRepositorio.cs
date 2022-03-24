using Entidad;

namespace Repositorio
{
    public interface IProductoRepositorio
    {
        Task<List<Producto>> ListarProductos(string codigo, string textoDescripcion);
    }
}
