using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlApplicationDal : IApplicationDal
    {
        public MsSqlApplicationDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Application> GelAll()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Application> applications = context.Applications.OrderBy(g => g.Name).ToList();
                return applications;
            }
        }

        public Application Add(Application application)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Application add = context.Applications.Add(application);
                return context.SaveChanges() ? add : null;
            }
        }

        public Application Update(Application application)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                context.Entry(application).State = EntityState.Modified;
                Application group1 = context.SaveChanges() ? application : null;
                return group1;
            }
        }

        public bool Delete(int appId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Application application = context.Applications.SingleOrDefault(u => u.Id == appId);
                if (application == null)
                {
                    return false;
                }

                context.Applications.Remove(application);
                return context.SaveChanges();
            }
        }
    }
}