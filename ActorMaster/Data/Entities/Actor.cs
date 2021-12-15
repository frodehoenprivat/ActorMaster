using ActorMaster.Enums;

namespace ActorMaster.Data.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public int CustomerNo { get; set; }
        public string? Name { get; set; }
        public ActorTypeEnum Type { get; set; }
        public bool IsActive { get; set; }
    }

    
}
