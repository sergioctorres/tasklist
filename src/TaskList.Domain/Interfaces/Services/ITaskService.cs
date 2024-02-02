namespace TaskList.Domain.Interfaces.Services
{
    public interface ITaskService : IService<Entities.Task>
    {
        Task Start(int id);
        Task End(int id);
    }
}
