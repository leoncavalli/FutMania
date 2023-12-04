using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutMania.Domain.Entities.Common;

namespace FutMania.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<bool> AddAsync(TEntity entity);
        Task<bool> AddRangeAsync(List<TEntity> entity);
        bool Remove(TEntity entity);
        Task<bool> RemoveAsync(string id);
        bool Update(TEntity entity);
        Task<int> SaveAsync();
    }
}