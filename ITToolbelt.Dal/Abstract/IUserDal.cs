using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IUserDal
    {
        List<User> GetAll();
        User Add(User user);
        User Update(User user);

        bool Get(int id, string username);
        bool Delete(int userId);
        bool SyncUsersWithAd(List<User> users);
        List<User> GetUserGroups(int groupId);
    }
}