using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutMania.Application.Repositories;
using FutMania.Domain.Entities.Common;
using FutMania.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FutMania.Persistance.Repositories
{
    public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly FutManiaDbContext _context;

        public WriteRepository(FutManiaDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public Task<bool> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeAsync(List<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}