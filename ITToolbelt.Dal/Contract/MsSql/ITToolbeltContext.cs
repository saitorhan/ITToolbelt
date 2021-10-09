using System;
using System.Data.Entity;
using ITToolbelt.Dal.Migrations;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class ItToolbeltContext : DbContext
    {
        public ItToolbeltContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItToolbeltContext, MsSqlConfiguration>());
        }

        public ItToolbeltContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItToolbeltContext, MsSqlConfiguration>());
        }

        public DbSet<Connection> Connections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Application> Applications { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOptional(u => u.SystemUser).WithRequired(su => su.User);
            modelBuilder.Entity<User>().HasMany(u => u.UserGroups).WithRequired(ug => ug.User)
                .HasForeignKey(ug => ug.UserId);
            modelBuilder.Entity<Group>().HasMany(u => u.UserGroups).WithRequired(ug => ug.Group)
                .HasForeignKey(ug => ug.GroupId);
            modelBuilder.Entity<User>().HasMany(u => u.Computers).WithOptional(c => c.User)
                .HasForeignKey(c => c.UserId);

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