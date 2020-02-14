namespace APIdotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bytesintab : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "Mail", c => c.String());
            AlterColumn("dbo.Excuses", "Image", c => c.Binary());
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Excuses", "Image", c => c.Byte(nullable: false));
            DropColumn("dbo.Users", "Mail");
            DropColumn("dbo.Users", "Password");
        }
    }
}
