using CINE.Api.Entities;
using CINE.Api.Repository.Intefaces;
using CINE.Api.Services.Interfaces;

namespace CINE.Api.Services
{
    public class SalaCineService : ISalaCineService
    {
        private readonly ISalaCineRepository _salaCineRepository;

        public SalaCineService(ISalaCineRepository salaCineRepository)
        {
            _salaCineRepository = salaCineRepository;
        }

        public async Task<SalaCine?> GetSalaCineByIdAsync(int id)
        {
            return await _salaCineRepository.GetSalaCineByIdAsync(id);
        }

        public async Task<IEnumerable<SalaCine>> GetAllSalasCineAsync()
        {
            return await _salaCineRepository.GetAllSalasCineAsync();
        }

        public async Task<SalaCine> CreateSalaCineAsync(SalaCine salaCine)
        {
            try
            {
                return await _salaCineRepository.CreateSalaCineAsync(salaCine);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la sala: " + ex.Message);
            }
        }

        public async Task<SalaCine> UpdateSalaCineAsync(SalaCine salaCine)
        {
            return await _salaCineRepository.UpdateSalaCineAsync(salaCine);
        }

        public async Task<bool> DeleteSalaCineAsync(int id)
        {
            return await _salaCineRepository.DeleteSalaCineAsync(id);
        }

    }
}
