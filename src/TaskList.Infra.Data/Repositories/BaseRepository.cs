using Microsoft.EntityFrameworkCore;
using TaskList.Domain.DbContexts;
using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace TaskList.Infra.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly TaskListDbContext _context;

        public BaseRepository(TaskListDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var existingEntity = await _context.Set<T>().FindAsync(id);

            if (existingEntity != null)
            {
                existingEntity.LogicalDelete();
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().Where(x => x.IsActive).ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            var entry = await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task UpdateAsync(int id, T entity)
        {
            var existingEntity = await _context.Set<T>().FindAsync(id);

            if (existingEntity != null)
            {
                entity.UpdatedAt = DateTimeOffset.UtcNow;
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
