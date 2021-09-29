using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Entity.EntityClass
{
    public class ConnectInfo
    {
        public ConnectInfo(string connectionString, DbServerType databaseType)
        {
            ConnectionString = connectionString;
            DatabaseType = databaseType;
        }

        public string ConnectionString { get; set; }
        public DbServerType DatabaseType { get; set; }
    }
}