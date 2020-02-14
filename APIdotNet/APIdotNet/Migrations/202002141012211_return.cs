namespace APIdotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _return : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Excuses", "Image", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Excuses", "Image", c => c.String());
        }
    }
}
