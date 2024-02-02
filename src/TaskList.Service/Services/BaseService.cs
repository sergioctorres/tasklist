using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace TaskList.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public Task<T> InsertAsync(T entity)
        {
            return _repository.InsertAsync(entity);
        }

        public Task UpdateAsync(int id, T entity)
        {
            entity.Id = id;
            return (_repository.UpdateAsync(id, entity));
        }
    }
}
