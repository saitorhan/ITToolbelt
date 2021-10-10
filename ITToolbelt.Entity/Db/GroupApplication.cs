using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Entity.Db
{
    public class GroupApplication
    {
        [Key, Column(Order = 0)]
        public int GroupId { get; set; }

        [Key, Column(Order = 1)]
        public int ApplicationId { get; set; }

        public Group Group { get; set; }
        public Application Application { get; set; }
    }
}