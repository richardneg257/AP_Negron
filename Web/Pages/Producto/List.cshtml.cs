using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repositorio;
using Web.Dtos;

namespace Web.Pages.Producto
{
    public class ListModel : PageModel
    {
        private readonly IProductoRepositorio productoRepositorio;
        private readonly IMapper mapper;

        public ListModel(IProductoRepositorio productoRepositorio, IMapper mapper)
        {
            this.productoRepositorio = productoRepositorio;
            this.mapper = mapper;
        }

        public IEnumerable<ProductoDto> Productos { get; set; }

        public async Task OnGet(string codigo, string textoDescripcion)
        {
            var entidades = await productoRepositorio.ListarProductos(codigo, textoDescripcion);
            Productos = mapper.Map<List<ProductoDto>>(entidades);
        }
    }
}
