namespace ITToolbelt.Dal.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class MySqlConfiguration : DbMigrationsConfiguration<ITToolbelt.Dal.Contract.MySql.ItToolbeltContextMySql>
    {
        public MySqlConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ITToolbelt.Dal.Contract.MySql.ItToolbeltContextMySql context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
