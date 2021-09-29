using System.ComponentModel.DataAnnotations;

namespace ITToolbelt.Entity.Db
{
    public class SystemUser
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public User User { get; set; }
    }
}