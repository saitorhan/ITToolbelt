using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlUserDal : IUserDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MySqlUserDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }
        public List<User> GetAll()
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                try
                {
                    List<User> users = context.Users.ToList();
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
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                User add = context.Users.Add(user);
                return context.SaveChanges() ? add : null;
            }
        }

        public User Update(User user)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<UserGroup> userGroups = user.UserGroups;
                user.UserGroups = null;

                context.Entry(user).State = EntityState.Modified;
                User user1 = context.SaveChanges() ? user : null;

                if (user1 != null)
                {
                    IQueryable<UserGroup> queryable = context.UserGroups.Where(ug => ug.UserId == user.Id);
                    context.UserGroups.RemoveRange(queryable);
                    if (context.SaveChanges() && userGroups != null)
                    {
                        context.UserGroups.AddRange(userGroups);
                        context.SaveChanges();
                    }
                }

                return user1;
            }
        }

        public bool Get(int id, string username)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                try
                {
                    bool any = context.Users.Any(u => u.Id != id && u.Username == username);
                    return any;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool Delete(int userId)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
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
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                foreach (User user in users)
                {
                    User userFromDb = context.Users.SingleOrDefault(u => u.Username == user.Username);
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
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                List<User> users = context.UserGroups.Include("User").Where(ug => ug.GroupId == groupId)
                    .Select(ug => ug.User).ToList();
                return users;
            }
        }
    }
}