using Microsoft.Extensions.DependencyInjection;
using TaskList.Domain.Interfaces.Services;
using TaskList.Service.Services;

namespace TaskList.Domain.DependencyResolution
{
    public static class Services
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
