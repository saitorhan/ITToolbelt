using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Entity.Db
{
    public class Metadata
    {
        public int Id { get; set; }
        public MetadataType MetadataType { get; set; }
        public string Value { get; set; }
    }
}