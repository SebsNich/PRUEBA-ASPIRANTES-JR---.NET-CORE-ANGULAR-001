using CINE.Api.Entities;
using CINE.Api.Entities.Context;
using CINE.Api.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace CINE.Api.Repository
{
    public class SalaCineRepository : ISalaCineRepository
    {
        private readonly CineContext _context;

        public SalaCineRepository(CineContext context)
        {
            _context = context;
        }

        public async Task<SalaCine?> GetSalaCineByIdAsync(int id)
        {
            return await _context.SalasCine
                                 .FirstOrDefaultAsync(s => s.IdSala == id && s.Estado);
        }

        public async Task<IEnumerable<SalaCine>> GetAllSalasCineAsync()
        {
            return await _context.SalasCine
                                 .Where(s => s.Estado)
                                 .ToListAsync();
        }

        public async Task<SalaCine> CreateSalaCineAsync(SalaCine salaCine)
        {
            var existingSala = await _context.SalasCine
                                              .FirstOrDefaultAsync(s => s.Nombre == salaCine.Nombre);

            if (existingSala != null)
            {
                throw new Exception("Ya existe una sala con ese nombre.");
            }

            await _context.SalasCine.AddAsync(salaCine);
            await _context.SaveChangesAsync();
            return salaCine;
        }

        public async Task<SalaCine> UpdateSalaCineAsync(SalaCine salaCine)
        {
            var existingSala = await _context.SalasCine
                                              .FirstOrDefaultAsync(s => s.Nombre == salaCine.Nombre && s.IdSala != salaCine.IdSala);

            if (existingSala != null)
            {
                throw new Exception("Ya existe una sala con ese nombre.");
            }

            _context.SalasCine.Update(salaCine);
            await _context.SaveChangesAsync();
            return salaCine;
        }

        public async Task<bool> DeleteSalaCineAsync(int id)
        {
            var salaCine = await _context.SalasCine
                                         .FirstOrDefaultAsync(s => s.IdSala == id);

            if (salaCine == null)
            {
                return false; 
            }

            _context.SalasCine.Remove(salaCine);
            await _context.SaveChangesAsync();
            return true; 
        }
    }
}
