using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITToolbelt.Entity.Db
{
    public class User
    {
        public int Id { get; set; }
        public int? SystemUserId { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Firsname")]
        public string Firstname { get; set; }
        
        [Required]
        [MaxLength(50)]
        [DisplayName("Surname")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Mail")]
        [DataType(DataType.EmailAddress)]
        [Index(IsUnique = true)]
        public string Mail { get; set; }


        public SystemUser SystemUser { get; set; }
        public List<UserGroup> UserGroups { get; set; }

        [NotMapped]
        [DisplayName("Full Name")]
        public string Fullname => $"{Firstname} {Surname}";
    }
}