using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BreakpointApp.Infrastructure.Repositories.Generic
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = ""
            );

        TEntity GetById(Guid id);

        void Insert(TEntity entity);

        void Delete(Guid id);

        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
    }
}
