using EnovationApp.DataAccess.Models;

namespace EnovationAssignment.IServices
{
    public interface IAnimalService
    {
        public Task<List<AnimalDto>> GetAllAnimalListAsync();
        public Task<AnimalDto> GetAnimalByIdAsync(int id);
        public Task CreateAsync(AnimalDto animal);
        public Task UpdateAsync(AnimalDto animal);
        public Task HardDeleteAsync(int id);
        public Task SoftDeleteAsync(int id);
    }
}
