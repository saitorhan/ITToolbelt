using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IGroupDal
    {
        List<Group> GelAll();
    }
}