using FutMania.Domain.Entities.Common;

namespace FutMania.Domain.Entities
{
    public class Season : BaseEntity
    {
        public Guid LeagueId { get; set; }
        public string Name { get; set; }
        public bool Finished { get; set; }
        public bool IsCurrent { get; set; }
        public string Info { get; set; }
        public League League { get; set; }
        
    }
}