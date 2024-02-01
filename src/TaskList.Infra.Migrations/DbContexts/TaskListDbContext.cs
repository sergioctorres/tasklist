using Microsoft.EntityFrameworkCore;
using TaskList.Domain.Entities;
using TaskList.Infra.Migrations.DbContexts.Mappings;

namespace TaskList.Infra.Migrations
{
    public class TaskListDbContext : DbContext
    {
        public TaskListDbContext(DbContextOptions<TaskListDbContext> options) : base(options) { }

        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskDbMapping());
            modelBuilder.ApplyConfiguration(new UserDbMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
