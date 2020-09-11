namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        FatherName = c.String(nullable: false, maxLength: 30),
                        DOB = c.String(),
                        GuardianName = c.String(nullable: false, maxLength: 30),
                        InstituteName = c.String(nullable: false, maxLength: 100),
                        Nationality = c.String(nullable: false, maxLength: 30),
                        CNIC = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 15),
                        CellNum = c.String(nullable: false),
                        EmergencyNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
