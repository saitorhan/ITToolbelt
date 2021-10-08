using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.MySql;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlComputerDal : IComputerDal
    {
        public MySqlComputerDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Computer> GelAll()
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<Computer> computers = context.Computers.Include("User").OrderBy(g => g.Name).ToList();
                return computers;
            }
        }

        public Computer Add(Computer computer)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                Computer add = context.Computers.Add(computer);
                return context.SaveChanges() ? add : null;
            }
        }

        public Computer Update(Computer computer)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                context.Entry(computer).State = EntityState.Modified;
                Computer cmptr = context.SaveChanges() ? computer : null;

                return cmptr;
            }
        }

        public bool Get(int id, string name)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                try
                {
                    bool any = context.Computers.Any(u => u.Id != id && u.Name == name);
                    return !any;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool Delete(int computerId)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                Computer computer = context.Computers.SingleOrDefault(u => u.Id == computerId);
                if (computer == null)
                {
                    return false;
                }

                context.Computers.Remove(computer);
                return context.SaveChanges();
            }
        }

        public List<Computer> GetUserComputers(int userId)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<Computer> computers = context.Computers.Where(ug => ug.UserId == userId).ToList();
                return computers;
            }
        }

        public bool SyncGroupsWithAd(List<Computer> computers)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                foreach (Computer group in computers)
                {
                    Group userFromDb = context.Groups.FirstOrDefault(u => u.Name == group.Name);
                    if (userFromDb == null)
                    {
                        context.Computers.Add(group);
                    }
                    else
                    {
                        userFromDb.Description = group.Desc;
                    }
                }

                return context.SaveChanges();
            }
        }
    }
}