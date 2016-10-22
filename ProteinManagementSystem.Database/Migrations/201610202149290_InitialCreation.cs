namespace ProteinManagementSystem.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proteins",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        AminoAcidSequence = c.String(nullable: false),
                        IsoelectricPoint = c.Double(),
                        MolecularWeight = c.Int(),
                        Description = c.String(nullable: false),
                        DateDiscovered = c.DateTime(),
                        DiscoveredBy = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proteins");
        }
    }
}
