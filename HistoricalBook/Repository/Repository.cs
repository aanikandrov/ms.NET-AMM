using System.Linq.Expressions;
using HistoricalBook.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HistoricalBook.DataAccess.Repository;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly IDbContextFactory<DbContext> _contextFactory;
    
    public Repository(IDbContextFactory<DbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }


    public IQueryable<T> GetAll()
    {
        using var dbContext = _contextFactory.CreateDbContext();
        return dbContext.Set<T>();
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
    {
        using var dbContext = _contextFactory.CreateDbContext();
        return dbContext.Set<T>().Where(predicate);
    }

    public T? GetById(int id)
    {
        using var dbContext = _contextFactory.CreateDbContext();
        return dbContext.Set<T>().FirstOrDefault(e => e.Id == id);
    }

    public T? GetById(Guid id)
    {
        using var dbContext = _contextFactory.CreateDbContext();
        return dbContext.Set<T>().FirstOrDefault(e => e.ExternalId == id);
    }

    public T Save(T entity)
    {
        // ааа, тут ничего нет!
        // но скоро обязательно будет!
    }

    public void Delete(T entity)
    {
        using var dbContext = _contextFactory.CreateDbContext();
        dbContext.Set<T>().Remove(entity);
        dbContext.SaveChanges();
    }
}