namespace ProteinManagementSystem.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProteinManagementSystem.Database.ProteinContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProteinManagementSystem.Database.ProteinContext context)
        {
            context.Proteins.AddOrUpdate(protein => protein.Name, ProteinDataExtractor.GetProteins().ToArray());
        }
    }
}
