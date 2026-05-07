using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class StatsRepository : ARepository<Stats>
{
    public StatsRepository(TresDbContext context) : base(context)
     {
        
    }
}