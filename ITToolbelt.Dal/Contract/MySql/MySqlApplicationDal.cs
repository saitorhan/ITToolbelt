using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlApplicationDal : IApplicationDal
    {
        public MySqlApplicationDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Application> GelAll()
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<Application> applications = context.Applications.OrderBy(g => g.Name).ToList();
                return applications;
            }
        }

        public Application Add(Application application)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                Application add = context.Applications.Add(application);
                return context.SaveChanges() ? add : null;
            }
        }

        public Application Update(Application application)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<GroupApplication> groupApplications = application.GroupApplications;
                application.GroupApplications = null;

                context.Entry(application).State = EntityState.Modified;
                Application update = context.SaveChanges() ? application : null;

                if (update != null)
                {
                    IQueryable<GroupApplication> queryable = context.GroupApplications.Where(ug => ug.ApplicationId == application.Id);
                    context.GroupApplications.RemoveRange(queryable);
                    if (context.SaveChanges() && groupApplications != null)
                    {
                        context.GroupApplications.AddRange(groupApplications);
                        context.SaveChanges();
                    }
                }

                return update;
            }
        }

        public bool Delete(int appId)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
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

        public List<Group> GetApplicationGroups(int applicationId)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<Group> groups = context.GroupApplications.Include("Group").Where(ga => ga.ApplicationId == applicationId)
                    .Select(ga => ga.Group).ToList();
                return groups;
            }
        }
    }
}