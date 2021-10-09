using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IApplicationDal
    {
        List<Application> GelAll();
        Application Add(Application application);
        Application Update(Application application);
        bool Delete(int appId);
    }
}