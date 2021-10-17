using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Entity.Db
{
    public class Metadata
    {
        public int Id { get; set; }

        [Index("Meta_IX_1", IsUnique = true), Column(Order = 0)]
        public MetadataType MetadataType { get; set; }

        [MaxLength(500)]
        [Required]
        [Index("Meta_IX_1", IsUnique = true), Column(Order = 1)]
        public string Value { get; set; }
    }
}