using CINE.Api.Entities;

namespace CINE.Api.Repository.Intefaces
{
    public interface IPeliculaRepository
    {
        Task<IEnumerable<Pelicula>> GetPeliculas();
        Task<Pelicula?> GetPeliculaById(int id);
        Task<bool> CreatePelicula(Pelicula pelicula);
        Task<bool> UpdatePelicula(Pelicula pelicula);
        Task<bool> DeletePelicula(int id);
    }
}
