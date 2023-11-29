using FutMania.Domain.Entities.Common;

namespace FutMania.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Info { get; set; }
    }
}