using CINE.Api.Entities;
using CINE.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CINE.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaCineController : ControllerBase
    {
        private readonly ISalaCineService _salaCineService;

        public SalaCineController(ISalaCineService salaCineService)
        {
            _salaCineService = salaCineService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalaCine>>> GetAllSalas()
        {
            var salas = await _salaCineService.GetAllSalasCineAsync();
            return Ok(salas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalaCine>> GetSalaById(int id)
        {
            var sala = await _salaCineService.GetSalaCineByIdAsync(id);
            if (sala == null)
            {
                return NotFound();
            }
            return Ok(sala);
        }

        [HttpPost]
        public async Task<ActionResult<SalaCine>> CreateSala([FromBody] SalaCine salaCine)
        {
            if (salaCine == null)
            {
                return BadRequest();
            }

            try
            {
                var createdSala = await _salaCineService.CreateSalaCineAsync(salaCine);
                return CreatedAtAction(nameof(GetSalaById), new { id = createdSala.IdSala }, createdSala);
            }
            catch (Exception ex)
            {
                return Conflict(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SalaCine>> UpdateSala(int id, [FromBody] SalaCine salaCine)
        {
            if (id != salaCine.IdSala)
            {
                return BadRequest();
            }

            var updatedSala = await _salaCineService.UpdateSalaCineAsync(salaCine);
            return Ok(updatedSala);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSala(int id)
        {
            var deleted = await _salaCineService.DeleteSalaCineAsync(id); 
            if (!deleted)
            {
                return NotFound(); 
            }

            return NoContent(); 
        }
    }
}
