using Domain.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;

namespace Domain.Repositories.Implementations;

public abstract class ARepository<T> : IRepository<T> where T : class
{
    protected TresDbContext _context;
    protected DbSet<T> _dbSet;

    public ARepository(TresDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public T Create(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
        _context.Entry(entity).Reload(); 
        return entity;
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public T? GetById(int Id)
    {
        return _dbSet.Find(Id);
    }
    
    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }
}