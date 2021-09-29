using System;
using System.Collections.Generic;
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
                List<User> users = context.Users.ToList();
                return users;
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

        public bool Get(int id, string mail)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                bool any = context.Users.Any(u => u.Id != id && u.Mail == mail);
                return any;
            }
        }
    }
}