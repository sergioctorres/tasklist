using Microsoft.Extensions.DependencyInjection;
using TaskList.Domain.Interfaces.Repositories;
using TaskList.Infra.Data.Repositories;

namespace TaskList.Domain.DependencyResolution
{
    public static class Repositories
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
