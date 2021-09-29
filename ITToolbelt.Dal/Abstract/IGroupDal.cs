using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IGroupDal
    {
        List<Group> GelAll();
        Group Add(Group group);
        Group Update(Group group);

        bool Get(int id, string name);
        bool Delete(int groupId);

        List<Group> GetUserGroups(int userId);
    }
}