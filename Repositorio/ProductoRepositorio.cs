using Entidad;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;

namespace Repositorio
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private readonly ApplicationDbContext context;

        public ProductoRepositorio(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Producto>> ListarProductos(string codigo, string textoDescripcion)
        {
            var query = context.Productos.Where(x => 1 == 1);

            if (!string.IsNullOrWhiteSpace(codigo)) query = query.Where(x => x.Codigo == codigo);
            if (!string.IsNullOrWhiteSpace(textoDescripcion)) query = query.Where(x => x.Descripcion.Contains(textoDescripcion));

            return await query.ToListAsync();
        }
    }
}
