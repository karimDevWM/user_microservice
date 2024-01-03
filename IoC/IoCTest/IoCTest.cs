using Microsoft.EntityFrameworkCore;
using userMicroservice.Data;
using userMicroservice.Data.Repository.Interface;
using userMicroservice.Data.Repository;
using userMicroservice.Services.Interface;
using userMicroservice.Services;

namespace userMicroservice.IoC.IoCTest
{
    public static class IoCTest
    {
        public static IServiceCollection ConfigureInjectionDependencyRepositoryTest(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection ConfigureInjectionDependencyServiceTest(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
        public static IServiceCollection ConfigureDBContextTest(this IServiceCollection services)
        {
            services.AddDbContext<DbContextClass>(options =>
                options.UseInMemoryDatabase(databaseName: "TestApplication")
            );

            return services;
        }
    }
}
