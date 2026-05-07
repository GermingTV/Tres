using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class UserRepository : ARepository<User>
{
    public UserRepository(TresDbContext context) : base(context)
    {
        
    }

    public override List<User> GetAll()
    {
        return _context.Set<User>().Include(u => u.Stats).ToList();
    }
}