using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FutMania.Application.Repositories;
using FutMania.Domain.Entities.Common;
using FutMania.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
namespace FutMania.Persistance.Repositories
{
    public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly FutManiaDbContext _context;
        
        public ReadRepository(FutManiaDbContext context)
        {
            _context = context;
        }
        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll() => Table;

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method)
            => Table.Where(method);
        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method)
                => await Table.FirstOrDefaultAsync(method);
        public async Task<TEntity> GetByIdAsync(string id)
            => await Table.FindAsync(id);

    }
}