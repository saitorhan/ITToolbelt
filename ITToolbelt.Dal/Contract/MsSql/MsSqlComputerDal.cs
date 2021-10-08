using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlComputerDal : IComputerDal
    {
        public MsSqlComputerDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Computer> GelAll()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Computer> computers = context.Computers.Include("User").OrderBy(g => g.Name).ToList();
                return computers;
            }
        }

        public Computer Add(Computer computer)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Computer add = context.Computers.Add(computer);
                return context.SaveChanges() ? add : null;
            }
        }

        public Computer Update(Computer computer)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                context.Entry(computer).State = EntityState.Modified;
                Computer cmptr = context.SaveChanges() ? computer : null;

                return cmptr;
            }
        }

        public bool Get(int id, string name)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
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
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
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
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Computer> computers = context.Computers.Where(ug => ug.UserId == userId).ToList();
                return computers;
            }
        }

        public bool SyncGroupsWithAd(List<Computer> computers)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
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

        public List<Computer> GetFreeComputers()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Computer> computers = context.Computers.Where(ug => ug.UserId == null).ToList();
                return computers;
            }
        }
    }
}