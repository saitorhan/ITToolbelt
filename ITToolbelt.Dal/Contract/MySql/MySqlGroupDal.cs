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

        public List<Group> GetUserGroups(int userId)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<Group> groups = context.UserGroups.Include("Group").Where(ug => ug.UserId == userId)
                    .Select(ug => ug.Group).ToList();
                return groups;
            }
        }
    }
}