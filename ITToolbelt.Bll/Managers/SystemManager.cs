using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class SystemManager
    {
        private ISystemDal iSystemDal;

        public SystemManager(ConnectInfo connectInfo)
        {
            iSystemDal = new NinjectModules(connectInfo).StandartKernel.Get<ISystemDal>();
        }

        public bool CheckDb()
        {
            bool databaseIfNotExists = iSystemDal.CreateDatabaseIfNotExists();
            return databaseIfNotExists;
        }
    }
}