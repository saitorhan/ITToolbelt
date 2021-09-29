using System.Collections.Generic;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlGroupDal : IGroupDal
    {
        public MsSqlGroupDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Group> GelAll()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Group> groups = context.Groups.ToList();
                return groups;
            }
        }
    }
}