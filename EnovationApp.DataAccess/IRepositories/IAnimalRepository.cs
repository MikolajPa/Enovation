﻿using EnovationApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnovationApp.DataAccess.IRepositories
{
    public interface IAnimalRepository
    {
        public Task<List<AnimalDto>> GetAllAnimalListAsync();
        public Task<AnimalDto> GetAnimalByIdAsync(int id);
        public Task CreateAsync(AnimalDto animal);
        public Task UpdateAsync(AnimalDto animal);
        public Task HardDeleteAsync(int id);
        public Task SoftDeleteAsync(int id);
    }
}
