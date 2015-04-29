namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HospitalDetails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ContactInfo = c.String(),
                        Rank = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HospitalDetails");
        }
    }
}
