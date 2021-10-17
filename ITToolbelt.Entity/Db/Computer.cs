using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITToolbelt.Entity.Db
{
    public class Computer
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }
        
        // [Index(IsUnique = true)] Validator sınıfında uniq sağlanıyor
        [MaxLength(30)]
        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }    

        [MaxLength(250)]
        [DisplayName("Description")]
        public string Desc { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

        [NotMapped] public string UserMail => User?.Mail;
    }
}