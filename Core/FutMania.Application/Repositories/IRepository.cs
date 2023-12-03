using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FutMania.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> Table { get; }

    }
}