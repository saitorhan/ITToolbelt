using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IUserDal
    {
        List<User> GetAll();
        User Add(User user);

        bool Get(int id, string mail);
    }
}