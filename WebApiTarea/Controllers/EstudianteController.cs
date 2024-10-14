using Microsoft.AspNetCore.Mvc;
using WebApiTarea.Models;

namespace WebApiTarea.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EstudianteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var estudiante = new Estudiante()
            {
                Nombre = "Nicolle Rosa Andujar",
                Matricula = "20231075",
                Carrera = "Desarrollo de software"
            };
            return Ok(estudiante);
        }
    }
}
