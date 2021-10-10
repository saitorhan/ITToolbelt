﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlGroupDal : IGroupDal
    {
        public MsSqlGroupDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Group> GelAll()
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Group> groups = context.Groups.OrderBy(g => g.Name).ToList();
                return groups;
            }
        }

        public Group Add(Group group)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Group add = context.Groups.Add(group);
                return context.SaveChanges() ? add : null;
            }
        }

        public Group Update(Group group)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<UserGroup> userGroups = group.UserGroups;
                group.UserGroups = null;
                List<GroupApplication> groupApplications = group.GroupApplications;
                group.GroupApplications = null;

                context.Entry(group).State = EntityState.Modified;
                Group group1 = context.SaveChanges() ? group : null;

                if (group1 != null)
                {
                    IQueryable<UserGroup> queryable = context.UserGroups.Where(ug => ug.GroupId == group.Id);
                    context.UserGroups.RemoveRange(queryable);
                    if (context.SaveChanges() && userGroups != null)
                    {
                        context.UserGroups.AddRange(userGroups);
                        context.SaveChanges();
                    }
                    
                    IQueryable<GroupApplication> queryable1 = context.GroupApplications.Where(ug => ug.GroupId == group.Id);
                    context.GroupApplications.RemoveRange(queryable1);
                    if (context.SaveChanges() && groupApplications != null)
                    {
                        context.GroupApplications.AddRange(groupApplications);
                        context.SaveChanges();
                    }
                }

                return group1;
            }
        }

        public bool Get(int id, string name)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                try
                {
                    bool any = context.Groups.Any(u => u.Id != id && u.Name == name);
                    return !any;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool Delete(int groupId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Group group = context.Groups.SingleOrDefault(u => u.Id == groupId);
                if (group == null)
                {
                    return false;
                }

                context.Groups.Remove(group);
                return context.SaveChanges();
            }
        }

        public List<Group> GetUserGroups(int userId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Group> groups = context.UserGroups.Include("Group").Where(ug => ug.UserId == userId)
                    .Select(ug => ug.Group).OrderBy(g => g.Name).ToList();
                return groups;
            }
        }

        public bool SyncGroupsWithAd(List<Group> groups)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                foreach (Group group in groups)
                {
                    Group userFromDb = context.Groups.FirstOrDefault(u => u.Name == group.Name);
                    if (userFromDb == null)
                    {
                        context.Groups.Add(group);
                    }
                    else
                    {
                        userFromDb.Description = group.Description;
                    }
                }

                return context.SaveChanges();
            }
        }

        public List<Application> GetGroupApplications(int groupId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Application> applications = context.GroupApplications.Include("Application").Where(ug => ug.GroupId == groupId)
                    .Select(ug => ug.Application).OrderBy(g => g.Name).ToList();
                return applications;
            }
        }
    }
}