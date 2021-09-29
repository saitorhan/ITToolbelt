using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITToolbelt.Entity.Db
{
    public class Group
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        [DisplayName("Group Name")]
        public string Name { get; set; }

        [MaxLength(500)]
        [DisplayName("Description")]
        public string Description { get; set; }

        public List<UserGroup> UserGroups { get; set; }
    }
}