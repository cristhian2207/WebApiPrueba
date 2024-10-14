using Microsoft.AspNetCore.Mvc;
using WebApiTarea.Models;

namespace WebApiTarea.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PlatosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<string> ingredientes = new List<string>()
            {
                "Queso",
                "Harina",
                "Salsa de tomate",
                "Levadura"
            };
            var platos = new Platos()
            {
                NombrePlato = "Pizza",
                Ingredientes = ingredientes
            };
            if (platos == null )
            {
                return BadRequest();
            }
            return Ok(platos);
        }
    }
}
