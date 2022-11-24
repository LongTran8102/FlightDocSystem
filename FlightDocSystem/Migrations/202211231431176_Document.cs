namespace FlightDocSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Document : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DocName = c.String(nullable: false),
                    FlightNO = c.String(nullable: false),
                    Type = c.String(nullable: false),
                    Creator = c.String(nullable: false),
                    Note = c.String(nullable: false),
                    DepartureDate = c.DateTime(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    Version = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            
            DropTable("dbo.Documents");
        }
    }
}
