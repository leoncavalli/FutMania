using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutMania.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<bool> AddAsync(TEntity entity);
        Task<bool> AddAsync(List<TEntity> entity);
        Task<bool> Remove(TEntity entity);
        Task<bool> Remove(string id);
        Task<bool> UpdateAsync(TEntity entity);
    }
}