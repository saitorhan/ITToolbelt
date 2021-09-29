using System;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlSystemDal : ISystemDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MsSqlSystemDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public bool CreateDatabaseIfNotExists()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
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