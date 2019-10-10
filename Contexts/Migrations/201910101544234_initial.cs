namespace Contexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        AppUserId = c.Int(nullable: false, identity: true),
                        Appusername = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AppUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppUsers");
        }
    }
}
