using System.ComponentModel.DataAnnotations;

namespace ITToolbelt.Entity.Db
{
    public class Application
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public string Publisher { get; set; }

        [Required]
        [MaxLength(20)]
        public string Version { get; set; }

        [Required]
        [MaxLength(6)]
        public string BuiltType { get; set; }
    }
}