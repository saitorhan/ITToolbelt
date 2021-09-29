using System;
using System.Data.Entity;
using ITToolbelt.Dal.Migrations;
using ITToolbelt.Entity.Db;
using MySql.Data.EntityFramework;

namespace ITToolbelt.Dal.Contract.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ItToolbeltContextMySql : DbContext
    {
        public ItToolbeltContextMySql()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItToolbeltContextMySql, MySqlConfiguration>());
        }

        public ItToolbeltContextMySql(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItToolbeltContextMySql, MySqlConfiguration>());
        }

        public DbSet<Connection> Connections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOptional(u => u.SystemUser).WithRequired(su => su.User);
            modelBuilder.Entity<User>().HasMany(u => u.UserGroups).WithRequired(ug => ug.User)
                .HasForeignKey(ug => ug.UserId);
            modelBuilder.Entity<Group>().HasMany(u => u.UserGroups).WithRequired(ug => ug.Group)
                .HasForeignKey(ug => ug.GroupId);

            base.OnModelCreating(modelBuilder);
        }

        public new bool SaveChanges()
        {
            try
            {
                return base.SaveChanges() >= 0;
            }
            catch (Exception e)
            {
#if DEBUG
                throw e;
#else
                return false;
#endif

            }
        }
    }
}