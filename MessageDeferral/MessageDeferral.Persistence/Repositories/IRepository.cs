using System.Linq.Expressions;

namespace MessageDeferral.Persistence.Repositories;

public interface IRepository<TEntity>
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    
    Task DeleteAsync(TEntity entity);
    Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    
    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellationToken = default);
    IQueryable<TEntity> Query(Expression<Func<TEntity, bool>>? predicate = null);
}