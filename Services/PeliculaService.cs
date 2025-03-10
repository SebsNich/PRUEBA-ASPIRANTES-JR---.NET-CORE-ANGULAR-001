using CINE.Api.Entities;
using CINE.Api.Repository.Intefaces;
using CINE.Api.Services.Interfaces;

namespace CINE.Api.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository _peliculaRepository;

        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        public async Task<IEnumerable<Pelicula>> GetPeliculas() => await _peliculaRepository.GetPeliculas();
        public async Task<Pelicula?> GetPeliculaById(int id) => await _peliculaRepository.GetPeliculaById(id);
        public async Task<bool> CreatePelicula(Pelicula pelicula) => await _peliculaRepository.CreatePelicula(pelicula);
        public async Task<bool> UpdatePelicula(Pelicula pelicula) => await _peliculaRepository.UpdatePelicula(pelicula);
        public async Task<bool> DeletePelicula(int id) => await _peliculaRepository.DeletePelicula(id);
    }
}
