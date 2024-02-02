using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces.Repositories;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }
    }
}
