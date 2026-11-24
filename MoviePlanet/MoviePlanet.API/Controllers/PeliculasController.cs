using Microsoft.AspNetCore.Mvc;
using MoviePlanet.Application.Services;
using MoviePlanet.Domain.Entities;

namespace MoviePlanet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly PeliculaService _peliService;

        public PeliculasController(PeliculaService peliService)
        {
            _peliService = peliService;
        }

        [HttpPost]
        public IActionResult CrearPeliculas(Pelicula pelicula)
        {
            try
            {
                var crearPelicula = _peliService.CrearPelicula(pelicula);

                return CreatedAtAction(nameof(CrearPeliculas),
                    new { id = crearPelicula.Id },
                    crearPelicula);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult MostrarPeliculas()
        {
            var peliculas = _peliService.MostrarPeliculas();

            return Ok(peliculas);
        }
    }
}
