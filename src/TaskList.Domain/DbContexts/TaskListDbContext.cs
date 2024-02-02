using Microsoft.EntityFrameworkCore;
using TaskList.Domain.DbContexts.Mappings;
using TaskList.Domain.Entities;

namespace TaskList.Domain.DbContexts
{
    public class TaskListDbContext : DbContext
    {
        public TaskListDbContext(DbContextOptions<TaskListDbContext> options) : base(options) { }

        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskDbMapping());
            modelBuilder.ApplyConfiguration(new UserDbMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
