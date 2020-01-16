namespace APIdotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Excuses", "User_Id", "dbo.Users");
            DropIndex("dbo.Excuses", new[] { "User_Id" });
            RenameColumn(table: "dbo.Excuses", name: "User_Id", newName: "UserID");
            AlterColumn("dbo.Excuses", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Excuses", "UserID");
            AddForeignKey("dbo.Excuses", "UserID", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Excuses", "UserID", "dbo.Users");
            DropIndex("dbo.Excuses", new[] { "UserID" });
            AlterColumn("dbo.Excuses", "UserID", c => c.Int());
            RenameColumn(table: "dbo.Excuses", name: "UserID", newName: "User_Id");
            CreateIndex("dbo.Excuses", "User_Id");
            AddForeignKey("dbo.Excuses", "User_Id", "dbo.Users", "Id");
        }
    }
}
