namespace LanParty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        MemberID = c.Int(nullable: false),
                        LanPartyID = c.Int(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        HasPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.MemberID, t.LanPartyID })
                .ForeignKey("dbo.LanParties", t => t.LanPartyID, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID)
                .Index(t => t.LanPartyID);
            
            CreateTable(
                "dbo.LanParties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        Type = c.String(),
                        MinPlayers = c.Int(nullable: false),
                        MaxPlayers = c.Int(nullable: false),
                        EstimatedPlayTime = c.Int(nullable: false),
                        IsCOOP = c.Boolean(nullable: false),
                        HostedPrivateServer = c.Boolean(nullable: false),
                        CrossPlatform = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GameOwneds",
                c => new
                    {
                        GameID = c.Int(nullable: false),
                        MemberID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GameID, t.MemberID })
                .ForeignKey("dbo.Games", t => t.GameID, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.GameID)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.Itineraries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LanPartyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LanParties", t => t.LanPartyID, cascadeDelete: true)
                .Index(t => t.LanPartyID);
            
            CreateTable(
                "dbo.ItineraryItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItineraryID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Activity = c.String(),
                        GameID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Games", t => t.GameID)
                .ForeignKey("dbo.Itineraries", t => t.ItineraryID, cascadeDelete: true)
                .Index(t => t.ItineraryID)
                .Index(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryItems", "ItineraryID", "dbo.Itineraries");
            DropForeignKey("dbo.ItineraryItems", "GameID", "dbo.Games");
            DropForeignKey("dbo.Itineraries", "LanPartyID", "dbo.LanParties");
            DropForeignKey("dbo.GameOwneds", "MemberID", "dbo.Members");
            DropForeignKey("dbo.GameOwneds", "GameID", "dbo.Games");
            DropForeignKey("dbo.Attendances", "MemberID", "dbo.Members");
            DropForeignKey("dbo.Attendances", "LanPartyID", "dbo.LanParties");
            DropIndex("dbo.ItineraryItems", new[] { "GameID" });
            DropIndex("dbo.ItineraryItems", new[] { "ItineraryID" });
            DropIndex("dbo.Itineraries", new[] { "LanPartyID" });
            DropIndex("dbo.GameOwneds", new[] { "MemberID" });
            DropIndex("dbo.GameOwneds", new[] { "GameID" });
            DropIndex("dbo.Attendances", new[] { "LanPartyID" });
            DropIndex("dbo.Attendances", new[] { "MemberID" });
            DropTable("dbo.ItineraryItems");
            DropTable("dbo.Itineraries");
            DropTable("dbo.GameOwneds");
            DropTable("dbo.Games");
            DropTable("dbo.Members");
            DropTable("dbo.LanParties");
            DropTable("dbo.Attendances");
        }
    }
}
