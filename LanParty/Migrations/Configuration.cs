namespace LanParty.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LanParty.Models.LanPartyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LanParty.Models.LanPartyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            // After adding LanParty and Members table data un comment Attendance section

            context.LanParty.AddOrUpdate(new LanParty.Models.LanParty
            {
                ID = 1,
                Date = new DateTime(2017, 12, 16),
                StartTime = new DateTime(2017, 12, 16, 10, 00, 00),
                EndTime = new DateTime(2017, 12, 17, 03, 00, 00),
                Location = "Sylrei's House"
            });
            context.LanParty.AddOrUpdate(new LanParty.Models.LanParty
            {
                ID = 2,
                Date = new DateTime(2018, 03, 17),
                StartTime = new DateTime(2018, 03, 17, 10, 00, 00),
                EndTime = new DateTime(2018, 03, 18, 03, 00, 00),
                Location = "Sylrei's House"
            });
            context.Members.AddOrUpdate(new Models.Members
            {
                ID = 1,
                UserName = "Sylrei",
                FirstName = "Kristen",
                LastName = "McIntosh",
                Email = "sylrei@testing.com",
                Phone = "(502)533-0567"

            });
            context.Members.AddOrUpdate(new Models.Members
            {
                ID = 2,
                UserName = "thundat00th",
                FirstName = "Reed",
                LastName = "McIntosh",
                Email = "thundat00th@testing.com",
                Phone = "(334)521-3004"

            });
            context.Members.AddOrUpdate(new Models.Members
            {
                ID = 3,
                UserName = "Zarch",
                FirstName = "Donnie",
                LastName = "Podhorsky",
                Email = "Zarch@testing.com",
                Phone = "(202)867-5309"

            });
            context.Members.AddOrUpdate(new Models.Members
            {
                ID = 4,
                UserName = "Kletus",
                FirstName = "Kyle",
                LastName = "Petruska",
                Email = "Kletus@testing.com",
                Phone = "(212)660-2242"

            });

            // Add After seed data for members and LanParty is entered
            //context.Attendance.AddOrUpdate(new Models.Attendance
            //{
            //    MemberID = 1,
            //    LanPartyID = 2,
            //    ArrivalTime = new DateTime(2018, 03, 17, 10, 00, 00),
            //    HasPaid = true

            //});
            //context.Attendance.AddOrUpdate(new Models.Attendance
            //{
            //    MemberID = 2,
            //    LanPartyID = 2,
            //    ArrivalTime = new DateTime(2018, 03, 17, 10, 00, 00),
            //    HasPaid = true

            //});
            //context.Attendance.AddOrUpdate(new Models.Attendance
            //{
            //    MemberID = 3,
            //    LanPartyID = 2,
            //    ArrivalTime = new DateTime(2018, 03, 17, 09, 30, 00),
            //    HasPaid = false

            //});
            //context.Attendance.AddOrUpdate(new Models.Attendance
            //{
            //    MemberID = 4,
            //    LanPartyID = 2,
            //    ArrivalTime = new DateTime(2018, 03, 17, 11, 00, 00),
            //    HasPaid = false

            //});

            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 1,
                GameName = "7 Days to Die",
                Type = "VG",
                MinPlayers = 1,
                MaxPlayers = 8,
                EstimatedPlayTime = 60,
                IsCOOP = true,
                HostedPrivateServer = true,
                CrossPlatform = true
            });
            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 2,
                GameName = "Prop-Hunt Garry's MOD",
                Type = "VG",
                MinPlayers = 2,
                MaxPlayers = 16,
                EstimatedPlayTime = 5,
                IsCOOP = true,
                HostedPrivateServer = true,
                CrossPlatform = true
            });
            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 3,
                GameName = "OverWatch",
                Type = "VG",
                MinPlayers = 1,
                MaxPlayers = 12,
                EstimatedPlayTime = 6,
                IsCOOP = true,
                HostedPrivateServer = false,
                CrossPlatform = false
            });

            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 4,
                GameName = "Telstrations",
                Type = "BG",
                MinPlayers = 4,
                MaxPlayers = 12,
                EstimatedPlayTime = 30,
                IsCOOP = null,
                HostedPrivateServer = null,
                CrossPlatform = null
            });

            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 5,
                GameName = "Munchkin",
                Type = "BG",
                MinPlayers = 3,
                MaxPlayers = 6,
                EstimatedPlayTime = 60,
                IsCOOP = null,
                HostedPrivateServer = null,
                CrossPlatform = null
            });

            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 6,
                GameName = "Humans Fall Flat",
                Type = "VG",
                MinPlayers = 1,
                MaxPlayers = 8,
                EstimatedPlayTime = 5,
                IsCOOP = true,
                HostedPrivateServer = false,
                CrossPlatform = true
            });

            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 7,
                GameName = "JackBox",
                Type = "VG",
                MinPlayers = 3,
                MaxPlayers = 8,
                EstimatedPlayTime = 5,
                IsCOOP = null,
                HostedPrivateServer = false,
                CrossPlatform = null
            });
            context.Games.AddOrUpdate(new Models.Games
            {
                ID = 8,
                GameName = "CodeNames",
                Type = "BG",
                MinPlayers = 2,
                MaxPlayers = null,
                EstimatedPlayTime = 45,
                IsCOOP = null,
                HostedPrivateServer = null,
                CrossPlatform = null
            });
        }
    }
}
