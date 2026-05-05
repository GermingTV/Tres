using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class UserRepository : ARepository<User>
{
    public UserRepository(TresDbContext context) : base(context)
    {
        
    }
}