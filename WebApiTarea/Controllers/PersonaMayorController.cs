using Microsoft.AspNetCore.Mvc;
using WebApiTarea.Models;

namespace WebApiTarea.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PersonaMayorController : Controller
    {
        [HttpPost]
        [Route("IsAdult")]
        public IActionResult IsAdult([FromBody] PersonaMayor persona)
        {
            if (persona == null)
            {
                return BadRequest("Datos invalidos");
            }

            bool isAdult = PersonaMiddleware.esAdulto(persona.FechaNacimiento);
            return Ok(isAdult);
        }
    }
}
