using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TaskList.Infra.Migrations.DbContexts.Mappings
{
    public class TaskDbMapping : IEntityTypeConfiguration<Domain.Entities.Task>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Task> builder)
        {
        }
    }
}
