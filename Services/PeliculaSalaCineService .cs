using CINE.Api.Entities;
using CINE.Api.Repository.Intefaces;
using CINE.Api.Services.Interfaces;

namespace CINE.Api.Services
{
    public class PeliculaSalaCineService : IPeliculaSalaCineService
    {
        private readonly IPeliculaSalaCineRepository _peliculaSalaCineRepository;

        public PeliculaSalaCineService(IPeliculaSalaCineRepository peliculaSalaCineRepository)
        {
            _peliculaSalaCineRepository = peliculaSalaCineRepository;
        }

        public async Task<PeliculaSalaCine?> GetPeliculaSalaCineByIdAsync(int id)
        {
            return await _peliculaSalaCineRepository.GetPeliculaSalaCineByIdAsync(id);
        }

        public async Task<IEnumerable<PeliculaSalaCine>> GetAllPeliculaSalaCineAsync()
        {
            return await _peliculaSalaCineRepository.GetAllPeliculaSalaCineAsync();
        }

        public async Task<PeliculaSalaCine> CreatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine)
        {
            return await _peliculaSalaCineRepository.CreatePeliculaSalaCineAsync(peliculaSalaCine);
        }

        public async Task<PeliculaSalaCine> UpdatePeliculaSalaCineAsync(PeliculaSalaCine peliculaSalaCine)
        {
            return await _peliculaSalaCineRepository.UpdatePeliculaSalaCineAsync(peliculaSalaCine);
        }

        public async Task DeletePeliculaSalaCineAsync(int id)
        {
            await _peliculaSalaCineRepository.DeletePeliculaSalaCineAsync(id);
        }
    }
}

