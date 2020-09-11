namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HostelModelValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DOB", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Students", "DOB", c => c.String());
        }
    }
}
