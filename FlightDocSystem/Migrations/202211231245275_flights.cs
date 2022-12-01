namespace FlightDocSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flights : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Flights", "Route");
            AddColumn("dbo.Flights", "To", c => c.String(nullable: false));
            AddColumn("dbo.Flights", "From", c => c.String(nullable: false));
           
            
           
        }
        
        public override void Down()
        {         
            DropTable("dbo.Flights");
        }
    }
}
