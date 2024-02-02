using TaskList.Domain.DbContexts;
using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces.Repositories;

namespace TaskList.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(TaskListDbContext context) : base(context)
        {
        }
    }
}
