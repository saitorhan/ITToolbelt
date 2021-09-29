using System.Collections.Generic;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Abstract
{
    public interface IConnectionDal
    {
        bool AddConnection(Connection connection);
        List<Connection> GetConnections(bool updateFromServer);
        List<Database> GetDatabases();
        List<Table> GetTables();
        bool Delete(int connectionId);
        bool Update(Connection connection);
    }
    
}