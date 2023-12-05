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

        public IQueryable<TEntity> GetAll(bool tracking=true) 
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query.AsNoTracking();
            return query;
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method,bool tracking=true)
        {   
            var query = Table.AsQueryable();
            if(!tracking)
                query.AsNoTracking();

            return query.Where(method);
        }
        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method,bool tracking=true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query.AsNoTracking();

            return await query.FirstOrDefaultAsync(method);
        }
        public async Task<TEntity> GetByIdAsync(string id,bool tracking=true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id ==Guid.Parse(id)); 
        
        }

    }
}