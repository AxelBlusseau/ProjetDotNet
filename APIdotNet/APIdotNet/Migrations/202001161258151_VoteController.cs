namespace APIdotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VoteController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        idExcuse = c.Int(nullable: false),
                        idUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idExcuse, t.idUser });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Votes");
        }
    }
}
