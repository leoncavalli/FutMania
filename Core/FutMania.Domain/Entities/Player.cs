using FutMania.Domain.Entities.Common;

namespace FutMania.Domain.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }
        
        
    }
}