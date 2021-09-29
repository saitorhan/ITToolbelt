namespace ITToolbelt.Entity.EntityClass
{
    public class Table
    {
        public short DatabaseId { get; set; }
        public int SchemaId { get; set; }
        public int TableId { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
    }
}