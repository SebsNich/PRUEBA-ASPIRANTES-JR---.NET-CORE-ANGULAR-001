using CINE.Api.Entities;

namespace CINE.Api.Services.Interfaces
{
    public interface IPeliculaSalaCineService
    {
        Task<PeliculaSalaCine?> GetPeliculaSalaCineByIdAsync(int id);
        Task<IEnumerable<PeliculaSalaCine>> GetAllPeliculaSalaCineAsync();
        Task<PeliculaSalaCine> CreatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine);
        Task<PeliculaSalaCine> UpdatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine);
        Task DeletePeliculaSalaCineAsync(int id);
    }
}
