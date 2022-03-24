using AutoMapper;
using Entidad;
using Servicios.Dtos;

namespace Servicios.Profiles
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, ProductoDto>();
        }
    }
}
