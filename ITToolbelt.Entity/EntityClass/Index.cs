using System.ComponentModel;

namespace ITToolbelt.Entity.EntityClass
{
    public class Index
    {
        [DisplayName("Schema Name")]
        public string Schema { get; set; }

        [DisplayName("Table Name")]
        public string Table { get; set; }

        [DisplayName("Index Name")]
        public string IndexName { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("AVG Fragmantation")]
        public double? Fragmantation { get; set; }

        [DisplayName("Page Count")]
        public long? PageCount { get; set; }
    }
}