using CINE.Api.Entities;

namespace CINE.Api.Repository.Intefaces
{
    public interface IPeliculaSalaCineRepository
    {
        Task<PeliculaSalaCine?> GetPeliculaSalaCineByIdAsync(int id);
        Task<IEnumerable<PeliculaSalaCine>> GetAllPeliculaSalaCineAsync();
        Task<PeliculaSalaCine> CreatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine);
        Task<PeliculaSalaCine> UpdatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine);
        Task DeletePeliculaSalaCineAsync(int id);
    }
}
