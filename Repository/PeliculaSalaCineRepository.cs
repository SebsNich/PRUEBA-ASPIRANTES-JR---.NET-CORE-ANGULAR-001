using CINE.Api.Entities;
using CINE.Api.Entities.Context;
using CINE.Api.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CINE.Api.Repository
{
    public class PeliculaSalaCineRepository : IPeliculaSalaCineRepository
    {
        private readonly CineContext _context;

        public PeliculaSalaCineRepository(CineContext context)
        {
            _context = context;
        }

        public async Task<PeliculaSalaCine?> GetPeliculaSalaCineByIdAsync(int id)
        {
            return await _context.PeliculasSalaCine
                                 .Include(ps => ps.Pelicula)
                                 .Include(ps => ps.SalaCine)
                                 .FirstOrDefaultAsync(ps => ps.IdPeliculaSala == id);
        }

        public async Task<IEnumerable<PeliculaSalaCine>> GetAllPeliculaSalaCineAsync()
        {
            return await _context.PeliculasSalaCine
                                 .Include(ps => ps.Pelicula)
                                 .Include(ps => ps.SalaCine)
                                 .ToListAsync();
        }

        public async Task<PeliculaSalaCine> CreatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine)
        {
            _context.PeliculasSalaCine.Add(peliculaSalaCine);
            await _context.SaveChangesAsync();
            return peliculaSalaCine;
        }

        public async Task<PeliculaSalaCine> UpdatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine)
        {
            _context.PeliculasSalaCine.Update(peliculaSalaCine);
            await _context.SaveChangesAsync();
            return peliculaSalaCine;
        }

        public async Task DeletePeliculaSalaCineAsync(int id)
        {
            var peliculaSalaCine = await GetPeliculaSalaCineByIdAsync(id);
            if (peliculaSalaCine != null)
            {
                _context.PeliculasSalaCine.Remove(peliculaSalaCine);
                await _context.SaveChangesAsync();
            }
        }
    }
}
