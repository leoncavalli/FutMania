using FutMania.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FutMania.Persistance.Contexts
{
    public class FutManiaDbContext : DbContext
    {
        public FutManiaDbContext(DbContextOptions options):base(options)
        {}

        public DbSet<Team> Teams { get;set; }
        public DbSet<League> Leagues { get;set; }
        public DbSet<Season> Seasons { get;set; }
        public DbSet<Player> Players { get;set; }


    }
}