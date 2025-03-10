using CINE.Api.Entities;
using CINE.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CINE.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaSalaCineController : ControllerBase
    {
        private readonly IPeliculaSalaCineService _peliculaSalaCineService;

        public PeliculaSalaCineController(IPeliculaSalaCineService peliculaSalaCineService)
        {
            _peliculaSalaCineService = peliculaSalaCineService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeliculaSalaCine>>> GetAllPeliculaSalaCine()
        {
            var peliculasSalas = await _peliculaSalaCineService.GetAllPeliculaSalaCineAsync();
            return Ok(peliculasSalas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PeliculaSalaCine>> GetPeliculaSalaCineById(int id)
        {
            var peliculaSalaCine = await _peliculaSalaCineService.GetPeliculaSalaCineByIdAsync(id);
            if (peliculaSalaCine == null)
            {
                return NotFound();
            }
            return Ok(peliculaSalaCine);
        }

        [HttpPost]
        public async Task<ActionResult<PeliculaSalaCine>> CreatePeliculaSalaCine([FromBody] PeliculaSalaCine peliculaSalaCine)
        {
            if (peliculaSalaCine == null)
            {
                return BadRequest();
            }

            var createdPeliculaSalaCine = await _peliculaSalaCineService.CreatePeliculaSalaCineAsync(peliculaSalaCine);
            return CreatedAtAction(nameof(GetPeliculaSalaCineById), new { id = createdPeliculaSalaCine.IdPeliculaSala }, createdPeliculaSalaCine);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PeliculaSalaCine>> UpdatePeliculaSalaCine(int id, [FromBody] PeliculaSalaCine peliculaSalaCine)
        {
            if (id != peliculaSalaCine.IdPeliculaSala)
            {
                return BadRequest();
            }

            var updatedPeliculaSalaCine = await _peliculaSalaCineService.UpdatePeliculaSalaCineAsync(peliculaSalaCine);
            return Ok(updatedPeliculaSalaCine);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePeliculaSalaCine(int id)
        {
            var peliculaSalaCine = await _peliculaSalaCineService.GetPeliculaSalaCineByIdAsync(id);
            if (peliculaSalaCine == null)
            {
                return NotFound();
            }

            await _peliculaSalaCineService.DeletePeliculaSalaCineAsync(id);
            return NoContent();
        }
    }
}
