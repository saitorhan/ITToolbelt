using System;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlSystemDal : ISystemDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MySqlSystemDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public bool CreateDatabaseIfNotExists()
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                try
                {
                    context.Database.CreateIfNotExists();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}