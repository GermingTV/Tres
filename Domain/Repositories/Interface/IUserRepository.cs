using Model.Entities;

namespace Domain.Repositories.Interface;

public interface IUserRepository : IRepository<User>
{
    new List<User> GetAll();
}