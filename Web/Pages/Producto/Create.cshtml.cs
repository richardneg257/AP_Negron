using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repositorio.Contexto;
using Web.Dtos;

namespace Web.Pages.Producto
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CreateModel(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [BindProperty]
        public ProductoCreacionDto Producto { get; set; }

        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPost()
        //{
        //    if (!ModelState.IsValid) return Page();

        //    ProductoCreacion.FechaRegistro = DateTime.Now;
        //    ProductoCreacion.Estado = 1;

        //    var entidad = mapper.Map<Producto>(ProductoCreacion);

        //    context.Add(entidad);
        //    await context.SaveChangesAsync();

        //    return RedirectToPage("List");
        //}
    }
}
