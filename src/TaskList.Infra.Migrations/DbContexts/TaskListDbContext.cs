using Microsoft.EntityFrameworkCore;
using TaskList.Domain.Entities;

namespace TaskList.Infra.Migrations
{
    public class TaskListDbContext : DbContext
    {
        public TaskListDbContext(DbContextOptions<TaskListDbContext> options) : base(options) { }

        public DbSet<Domain.Entities.Task> Task { get; set; }
        public DbSet<User> User { get; set; }
    }
}
