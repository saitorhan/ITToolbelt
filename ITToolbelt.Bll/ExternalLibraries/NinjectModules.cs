using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Dal.Contract.MySql;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using Ninject;
using Ninject.Modules;

namespace ITToolbelt.Bll.ExternalLibraries
{
    public class NinjectModules : NinjectModule
    {
        private ConnectInfo connectInfo;

        public NinjectModules(ConnectInfo connectInfo)
        {
            this.connectInfo = connectInfo;
            StandartKernel = new StandardKernel();
            Load();
        }

        public IKernel StandartKernel { get; set; }
        public sealed override void Load()
        {
            switch (connectInfo.DatabaseType)
            {
                case DbServerType.MsSql:
                    LoadMsSql();
                    break;
                case DbServerType.MySql:
                    LoadMySql();
                    break;
                default:
                    break;
            }
        }

        private void LoadMsSql()
        {
            StandartKernel.Bind<IConnectionDal>().To<MsSqlConnectionDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<IIndexDal>().To<MsSqlIndexDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<ISystemDal>().To<MsSqlSystemDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<IUserDal>().To<MsSqlUserDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<IGroupDal>().To<MsSqlGroupDal>().WithConstructorArgument("connectInfo", connectInfo);
        }
        private void LoadMySql()
        {
            StandartKernel.Bind<IConnectionDal>().To<MySqlConnectionDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<IIndexDal>().To<MySqlIndexDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<ISystemDal>().To<MySqlSystemDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<IUserDal>().To<MySqlUserDal>().WithConstructorArgument("connectInfo", connectInfo);
            StandartKernel.Bind<IGroupDal>().To<MySqlGroupDal>().WithConstructorArgument("connectInfo", connectInfo);
        }
    }
}