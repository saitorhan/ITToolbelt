using System.Collections.Generic;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class GroupManager
    {
        private IGroupDal iGroupDal;

        public GroupManager(ConnectInfo connectInfo)
        {
            iGroupDal = new NinjectModules(connectInfo).StandartKernel.Get<IGroupDal>();
        }

        public List<Group> GetAll()
        {
            return iGroupDal.GelAll();
        }
    }
}