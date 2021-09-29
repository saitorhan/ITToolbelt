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
                context.Entry(user).State = EntityState.Modified;
                return context.SaveChanges() ? user : null;
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
    }
}