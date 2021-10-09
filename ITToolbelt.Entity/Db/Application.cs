using System.ComponentModel.DataAnnotations;

namespace ITToolbelt.Entity.Db
{
    public class Application
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Version { get; set; }
        public string BuiltType { get; set; }
    }
}