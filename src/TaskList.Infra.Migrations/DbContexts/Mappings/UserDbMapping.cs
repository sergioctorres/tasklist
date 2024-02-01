using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskList.Domain.Entities;

namespace TaskList.Infra.Migrations.DbContexts.Mappings
{
    public class UserDbMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
        }
    }
}
