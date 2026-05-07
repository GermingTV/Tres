using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configuration;

public class TresDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Stats> Stats { get; set; }
    public TresDbContext(DbContextOptions<TresDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>().HasOne(u => u.Stats).WithOne().HasForeignKey<User>(u => u.StatsId);
    
    }

}