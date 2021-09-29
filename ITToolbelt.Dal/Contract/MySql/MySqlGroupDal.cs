using System.Collections.Generic;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlGroupDal:IGroupDal
    {
        public MySqlGroupDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Group> GelAll()
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<Group> groups = context.Groups.ToList();
                return groups;
            }
        }
    }
}