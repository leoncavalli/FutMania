using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutMania.Application.Repositories;
using FutMania.Domain.Entities;
using FutMania.Persistance.Contexts;

namespace FutMania.Persistance.Repositories
{
    public class PlayerWriteRepository : WriteRepository<Player>, IPlayerWriteRepository
    {
        public PlayerWriteRepository(FutManiaDbContext context) : base(context)
        {
        }
    }
}