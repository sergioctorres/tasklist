using TaskList.Domain.DbContexts;
using TaskList.Domain.Interfaces.Repositories;

namespace TaskList.Infra.Data.Repositories
{
    public class TaskRepository : BaseRepository<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(TaskListDbContext context) : base(context)
        {
        }
    }
}
