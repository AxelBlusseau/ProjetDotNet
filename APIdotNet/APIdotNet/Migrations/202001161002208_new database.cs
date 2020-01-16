namespace APIdotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Excuses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reason = c.String(),
                        Date = c.DateTime(nullable: false),
                        Image = c.String(),
                        NbVote = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Excuses", "User_Id", "dbo.Users");
            DropIndex("dbo.Excuses", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Excuses");
        }
    }
}
