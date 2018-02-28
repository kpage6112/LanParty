namespace LanParty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNulls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "IsCOOP", c => c.Boolean());
            AlterColumn("dbo.Games", "HostedPrivateServer", c => c.Boolean());
            AlterColumn("dbo.Games", "CrossPlatform", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "CrossPlatform", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Games", "HostedPrivateServer", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Games", "IsCOOP", c => c.Boolean(nullable: false));
        }
    }
}
