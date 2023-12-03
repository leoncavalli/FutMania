using FutMania.Domain.Entities.Common;

namespace FutMania.Domain.Entities
{
    public class League : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string ShortCode { get; set; }
        public string Info { get; set; }
    }
}