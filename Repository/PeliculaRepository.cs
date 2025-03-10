using CINE.Api.Entities;
using CINE.Api.Entities.Context;
using CINE.Api.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace CINE.Api.Repository
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly CineContext _context;
        public PeliculaRepository(CineContext context)
        {
            _context = context;
        }

        public async Task<bool> CreatePelicula(Pelicula pelicula)
        {
            _context.Peliculas.Add(pelicula);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeletePelicula(int id)
        {
            var pelicula = await GetPeliculaById(id);
            if (pelicula == null) return false;

            _context.Peliculas.Remove(pelicula);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Pelicula?> GetPeliculaById(int id)
        {
            return await _context.Peliculas.FindAsync(id);
        }

        public async Task<IEnumerable<Pelicula>> GetPeliculas()
        {
            return await _context.Peliculas.ToListAsync();
        }

        public async Task<bool> UpdatePelicula(Pelicula pelicula)
        {
            _context.Peliculas.Update(pelicula);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
