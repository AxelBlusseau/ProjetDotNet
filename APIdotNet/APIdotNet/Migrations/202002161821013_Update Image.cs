namespace APIdotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Excuses", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Excuses", "Image", c => c.Binary());
        }
    }
}
