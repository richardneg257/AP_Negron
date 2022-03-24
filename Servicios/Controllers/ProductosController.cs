using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repositorio;
using Servicios.Dtos;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepositorio productoRepositorio;
        private readonly IMapper mapper;

        public ProductosController(IProductoRepositorio productoRepositorio, IMapper mapper)
        {
            this.productoRepositorio = productoRepositorio;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductoDto>> Get(string? codigo, string? textoDescripcion)
        {
            var entidades = await productoRepositorio.ListarProductos(codigo, textoDescripcion);
            return mapper.Map<List<ProductoDto>>(entidades);
        }
    }
}