using AutoMapper;
using Entidad;
using Web.Dtos;

namespace Web.Profiles
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, ProductoDto>();
        }
    }
}
