using EnovationApp.DataAccess.IRepositories;
using EnovationApp.DataAccess.Models;
using EnovationAssignment.Helpers;
using EnovationAssignment.IServices;
using FluentValidation;

namespace EnovationAssignment.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly IValidator<AnimalDto> _animalValidator;
        public AnimalService(IAnimalRepository animalRepository, IValidator<AnimalDto> animalValidator)
        {
            _animalRepository = animalRepository;
            _animalValidator = animalValidator ?? throw new ArgumentException();
        }
        public async Task CreateAsync(AnimalDto animal)
        {
            var validationResult = _animalValidator.Validate(animal);
            if (!validationResult.IsValid)
                throw new AppException(validationResult.ToString());
            await _animalRepository.CreateAsync(animal);
        }

        public async Task<List<AnimalDto>> GetAllAnimalListAsync()
        {
            return await _animalRepository.GetAllAnimalListAsync();
        }

        public async Task<AnimalDto> GetAnimalByIdAsync(int id)
        {
            return await _animalRepository.GetAnimalByIdAsync(id);
        }

        public async Task HardDeleteAsync(int id)
        {
            await _animalRepository.HardDeleteAsync(id);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _animalRepository.SoftDeleteAsync(id);
        }

        public async Task UpdateAsync(AnimalDto animal)
        {
            var validationResult = _animalValidator.Validate(animal);
            if (!validationResult.IsValid)
                throw new AppException(validationResult.ToString());
            await _animalRepository.UpdateAsync(animal);
        }
    }
}
