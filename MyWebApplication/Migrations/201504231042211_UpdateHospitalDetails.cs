namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateHospitalDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HospitalDetails", "WebsiteLink", c => c.String());
            AddColumn("dbo.HospitalDetails", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HospitalDetails", "Address");
            DropColumn("dbo.HospitalDetails", "WebsiteLink");
        }
    }
}
