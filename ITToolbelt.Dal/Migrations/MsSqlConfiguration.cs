namespace ITToolbelt.Dal.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class MsSqlConfiguration : DbMigrationsConfiguration<ITToolbelt.Dal.Contract.MsSql.ItToolbeltContext>
    {
        public MsSqlConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ITToolbelt.Dal.Contract.MsSql.ItToolbeltContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
