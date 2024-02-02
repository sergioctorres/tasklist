using Microsoft.EntityFrameworkCore;
using TaskList.DependencyResolution;
using TaskList.Domain.DbContexts;
using TaskList.Domain.DependencyResolution;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("appsettings.json");

if (builder.Environment.IsDevelopment())
    builder.Configuration.AddJsonFile("appsettings.Development.json", optional: true);

var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TaskListDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

Mappers.Configure(builder.Services);
Repositories.Configure(builder.Services);
Services.Configure(builder.Services);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
