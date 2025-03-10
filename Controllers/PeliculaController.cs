using CINE.Api.Entities;
using CINE.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CINE.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaService _peliculaService;

        public PeliculaController(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPeliculas() => Ok(await _peliculaService.GetPeliculas());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPeliculaById(int id) => Ok(await _peliculaService.GetPeliculaById(id));

        [HttpPost]
        public async Task<IActionResult> CreatePelicula([FromBody] Pelicula pelicula)
        {
            if (pelicula == null)
            {
                return BadRequest("La película es nula.");
            }

            // Añadir la película al contexto de datos
            await _peliculaService.CreatePelicula(pelicula);

            // Devolver el objeto creado con su Id asignado
            return CreatedAtAction(nameof(GetPeliculas), new { id = pelicula.IdPelicula }, pelicula);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePelicula([FromBody] Pelicula pelicula) => Ok(await _peliculaService.UpdatePelicula(pelicula));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePelicula(int id) => Ok(await _peliculaService.DeletePelicula(id));
    }
}
