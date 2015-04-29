namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReviewEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReviewEntries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.String(),
                        userName = c.String(),
                        userFeedback = c.String(),
                        userRating = c.Int(nullable: false),
                        hospitalId = c.Int(nullable: false),
                        DateTime = c.String(),
                        userAge = c.Int(nullable: false),
                        userLocation = c.String(),
                        isValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReviewEntries");
        }
    }
}
