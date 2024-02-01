using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TaskList.Domain.DbContexts;

var builder = Host.CreateDefaultBuilder(args);


builder.ConfigureServices((context, services) =>
{
    services.AddDbContext<TaskListDbContext>(options =>
        options.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection"), o => o.MigrationsAssembly("TaskList.Infra.Migrations")));
});

var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<TaskListDbContext>();
    dbContext.Database.Migrate();
}