using EnovationApp.DataAccess.IRepositories;
using EnovationApp.DataAccess.Models;
using EnovationApp.DataAccess.Repositories;
using EnovationAssignment.IServices;
using EnovationAssignment.Services;
using EnovationAssignment.Validators;
using FluentValidation;

namespace EnovationAssignment
{
    public static class IocExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAnimalService, AnimalService>();

        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
        }

        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<AnimalDto>, AnimalValidator>();
        }
    }
}
