using EntityFramework.Infrastructure.Data;
using EntityFramwork.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Infrastructure.Repositories;

public class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly EfDemoDbContext _dbContext = new EfDemoDbContext();
    
    public int Insert(T obj)
    {
        _dbContext.Set<T>().Add(obj);
        _dbContext.SaveChanges();
        return 1;
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        if (entity == null) return 0;
        _dbContext.Set<T>().Remove(entity);
        _dbContext.SaveChanges();
        return 1;

    }

    public int Update(T obj)
    {
        _dbContext.Entry(obj).State = EntityState.Modified;
        _dbContext.SaveChanges();
        return 1;
    }

    public T? GetById(int id)
    {
        return _dbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbContext.Set<T>().ToList();
    }
}