using TaskList.Domain.Exceptions;
using TaskList.Domain.Interfaces.Repositories;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.Service.Services
{
    public class TaskService : BaseService<Domain.Entities.Task>, ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task Start(int id)
        {
            var task = await _repository.GetAsync(id);

            if (task == null)
                throw new BusinessRuleException($"Tarefa não encontrada com o ID {id}");

            if (task.EndDate != null)
                throw new BusinessRuleException($"Não é possível iniciar uma Tarefa que já foi encerrada");

            task.Start();

            await _repository.UpdateAsync(id, task);
        }

        public async Task End(int id)
        {
            var task = await _repository.GetAsync(id);

            if (task == null)
                throw new BusinessRuleException($"Tarefa não encontrada com o ID {id}");

            if (task.StartDate == null)
                throw new BusinessRuleException($"Não é possível encerrar uma Tarefa que não foi iniciada");

            task.End();

            await _repository.UpdateAsync(id, task);
        }
    }
}
