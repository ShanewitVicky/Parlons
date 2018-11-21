namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialPost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostMsg = c.Int(nullable: false),
                        PostTime = c.DateTime(nullable: false, precision: 0),
                        userId_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Users", t => t.userId_UserId, cascadeDelete: true)
                .Index(t => t.userId_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "userId_UserId", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "userId_UserId" });
            DropTable("dbo.Posts");
        }
    }
}
