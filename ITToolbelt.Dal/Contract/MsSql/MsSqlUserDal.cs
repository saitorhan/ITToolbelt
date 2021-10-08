using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlUserDal : IUserDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MsSqlUserDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }
        public List<User> GetAll()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                try
                {
                    List<User> users = context.Users.OrderBy(u => u.Username).ToList();
                    return users;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public User Add(User user)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                User add = context.Users.Add(user);
                return context.SaveChanges() ? add : null;
            }
        }

        public User Update(User user)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<UserGroup> userGroups = user.UserGroups;
                user.UserGroups = null;
                List<int> userIds = null;
                if (user.Computers != null)
                {
                    userIds = user.Computers.Select(c => c.Id).ToList();
                }

                user.Computers = null;
                context.Entry(user).State = EntityState.Modified;
                User user1 = context.SaveChanges() ? user : null;

                if (user1 != null)
                {
                    IQueryable<UserGroup> queryable = context.UserGroups.Where(ug => ug.UserId == user.Id);
                    context.UserGroups.RemoveRange(queryable);
                    if (context.SaveChanges() && userGroups!= null)
                    {
                        context.UserGroups.AddRange(userGroups);
                        context.SaveChanges();
                    }

                    foreach (Computer computer in context.Computers.Where(c => c.UserId == user.Id))
                    {
                        computer.UserId = null;
                    }

                    if (userIds != null)
                    {
                        foreach (Computer computer in context.Computers.Where(c => userIds.Contains(c.Id)))
                        {
                            computer.UserId = user.Id;
                        }
                    }

                    context.SaveChanges();
                }

                return user1;
            }
        }

        public bool Get(int id, string username)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                try
                {
                    bool any = context.Users.Any(u => u.Id != id && u.Username == username);
                    return !any;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool Delete(int userId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                User user = context.Users.SingleOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    return false;
                }

                context.Users.Remove(user);
                return context.SaveChanges();
            }
        }

        public bool SyncUsersWithAd(List<User> users)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                foreach (User user in users)
                {
                    User userFromDb = context.Users.FirstOrDefault(u => u.Username == user.Username);
                    if (userFromDb == null)
                    {
                        context.Users.Add(user);
                    }
                    else
                    {
                        userFromDb.Firstname = user.Firstname;
                        userFromDb.Surname = user.Surname;
                        userFromDb.Mail = user.Mail;
                    }
                }

                return context.SaveChanges();
            }
        }

        public List<User> GetUserGroups(int groupId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<User> users = context.UserGroups.Include("User").Where(ug => ug.GroupId == groupId)
                    .Select(ug => ug.User).OrderBy(u => u.Username).ToList();
                return users;
            }
        }
    }
}