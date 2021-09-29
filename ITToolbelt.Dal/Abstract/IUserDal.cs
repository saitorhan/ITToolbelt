using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IUserDal
    {
        List<User> GetAll();
        User Add(User user);
        User Update(User user);

        bool Get(int id, string mail);
        bool Delete(int userId);
    }
}