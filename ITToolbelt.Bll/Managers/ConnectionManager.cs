using System;
using System.Collections.Generic;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class ConnectionManager
    {
        private IConnectionDal iConnectionDal;

        public ConnectionManager(ConnectInfo connectInfo)
        {
            iConnectionDal  = new NinjectModules(connectInfo).StandartKernel.Get<IConnectionDal>();
        }

        public bool Add(Connection connection)
        {
            connection.CreateDate = DateTime.Now;

            bool b = iConnectionDal.AddConnection(connection);
            return b;
        }

        public List<Connection> GetConnections(bool updateFromServer)
        {
            List<Connection> connections = iConnectionDal.GetConnections(updateFromServer);
            return connections;
        }

        public List<Database> GetDatabases()
        {
            List<Database> databases = iConnectionDal.GetDatabases();
            return databases;
        }
        public List<Table> GetTables()
        {
            List<Table> tables = iConnectionDal.GetTables();
            return tables;
        }

        public bool Delete(int connectionId)
        {
            bool result = iConnectionDal.Delete(connectionId);
            return result;
        }

        public bool Update(Connection connection)
        {
            bool result = iConnectionDal.Update(connection);
            return result;
        }
    }
}