namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        EmailID = c.String(nullable: false, unicode: false),
                        FirstName = c.String(nullable: false, unicode: false),
                        LastName = c.String(nullable: false, unicode: false),
                        PhoneNumber = c.String(nullable: false, unicode: false),
                        About = c.String(nullable: false, unicode: false),
                        NickName = c.String(nullable: false, unicode: false),
                        DateOfBirth = c.String(nullable: false, unicode: false),
                        ProfilePicture = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
