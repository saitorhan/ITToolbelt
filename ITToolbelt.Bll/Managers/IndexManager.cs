using System.Collections.Generic;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Shared;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class IndexManager
    {
        private IIndexDal iIndexDal;

        public IndexManager(ConnectInfo connectInfo)
        {
            iIndexDal = new NinjectModules(connectInfo).StandartKernel.Get<IIndexDal>();
        }

        public List<Index> GetIndexes()
        {
            List<Index> indexes = iIndexDal.GetIndexes();
            return indexes;
        }

        public List<Index> SetDisable(List<Index> indexes)
        {
            foreach (Index index in indexes)
            {
                bool disable = iIndexDal.SetDisable(index);
                index.State = disable ? Resource._006 : Resource._007;
            }

            return indexes;
        }

        public List<Column> GetColumns(Index index)
        {
            List<Column> columns = iIndexDal.GetColumns(index);
            return columns;
        }
    }
}