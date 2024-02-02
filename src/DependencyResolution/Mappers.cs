using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TaskList.Domain.Mapping;

namespace TaskList.DependencyResolution
{
    public static class Mappers
    {
        public static void Configure(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
