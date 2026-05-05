namespace Domain.Repositories.Interface;

public interface IRepository<T> where T : class
{
    T Create(T entity);
    
    void Update(T entity);
    
    T? GetById(int id);
    
    void Delete(T entity);

    List<T> GetAll();
}