using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITToolbelt.Entity.Db
{
    public class Computer
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Desc { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}