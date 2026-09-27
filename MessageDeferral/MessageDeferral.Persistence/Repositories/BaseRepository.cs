using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace MessageDeferral.Persistence.Repositories;

public class BaseRepository<TEntity>(DomainDbContext context) : IRepository<TEntity>
    where TEntity : class
{
    public async Task AddAsync(TEntity entity)
    {
        await context.Set<TEntity>().AddAsync(entity);
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        await context.Set<TEntity>().AddRangeAsync(entities, cancellationToken);
    }

    public Task DeleteAsync(TEntity entity)
    {
        context.Set<TEntity>().Remove(entity);
        return Task.CompletedTask;
    }

    public Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        context.Set<TEntity>().RemoveRange(entities);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        context.Set<TEntity>().Update(entity);
        return Task.CompletedTask;
    }

    public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await context.Set<TEntity>().FindAsync(id, cancellationToken);
    }

    public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellationToken = default)
    {
        if (predicate is not null)
            return await context.Set<TEntity>().Where(predicate!).ToListAsync(cancellationToken);
        
        return await context.Set<TEntity>().ToListAsync(cancellationToken);
    }

    public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>>? predicate = null)
    {
        if (predicate is not null)
            return context.Set<TEntity>().Where(predicate).AsQueryable();
        
        return context.Set<TEntity>().AsQueryable();
    }
}