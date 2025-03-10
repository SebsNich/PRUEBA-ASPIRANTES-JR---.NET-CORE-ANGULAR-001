using CINE.Api.Entities;

namespace CINE.Api.Services.Interfaces
{
    public interface ISalaCineService
    {
        Task<SalaCine?> GetSalaCineByIdAsync(int id);
        Task<IEnumerable<SalaCine>> GetAllSalasCineAsync();
        Task<SalaCine> CreateSalaCineAsync(SalaCine salaCine);
        Task<SalaCine> UpdateSalaCineAsync(SalaCine salaCine);
        Task<bool> DeleteSalaCineAsync(int id);
    }
}
