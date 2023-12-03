using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FutMania.Application.Repositories
{
    public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method);
        Task<TEntity> GetByIdAsync(string id);
    }
}