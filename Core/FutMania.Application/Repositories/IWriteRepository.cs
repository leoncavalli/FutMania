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
        Task<bool> Remove(TEntity entity);
        Task<bool> Remove(string id);
        Task<bool> UpdateAsync(TEntity entity);
    }
}