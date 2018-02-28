namespace LanParty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNulls1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "MaxPlayers", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "MaxPlayers", c => c.Int(nullable: false));
        }
    }
}
