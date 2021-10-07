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
        [MaxLength(20)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [MaxLength(250)]
        [DisplayName("Description")]
        public string Desc { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

        [DisplayName("User")] 
        [NotMapped] 
        public string UserName => User == null ? String.Empty : User.Fullname;
    }
}