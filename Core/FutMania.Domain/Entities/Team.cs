using FutMania.Domain.Entities.Common;

namespace FutMania.Domain.Entities
{
    public class Team : BaseEntity
    {
        public Guid LeagueId { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Country { get; set; }
        public int Founded {get;set;}
        public string Info {get;set;}

        public League League { get; set; }
    }
}