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
                Date = new DateTime(2017, 12, 16),
                StartTime = new DateTime(2017, 12, 16, 10, 00, 00),
                EndTime = new DateTime(2017, 12, 17, 03, 00, 00),
                Location = "Sylrei's House"
            });
        context.LanParty.AddOrUpdate(new LanParty.Models.LanParty
            {
                Date = new DateTime(2018, 03, 17),
                StartTime = new DateTime(2018, 03, 17, 10, 00, 00),
                EndTime = new DateTime(2018, 03, 18, 03, 00, 00),
                Location = "Sylrei's House"
            });
        context.Members.AddOrUpdate(new Models.Members
            {
                UserName = "Sylrei",
                FirstName = "Kristen",
                LastName = "McIntosh",
                Email = "sylrei@testing.com",
                Phone = "(502)533-0567"

            });
        context.Members.AddOrUpdate(new Models.Members
            {
                UserName = "thundat00th",
                FirstName = "Reed",
                LastName = "McIntosh",
                Email = "thundat00th@testing.com",
                Phone = "(334)521-3004"

            });
        context.Members.AddOrUpdate(new Models.Members
           {
                UserName = "Zarch",
                FirstName = "Donnie",
                LastName = "Podhorsky",
                Email = "Zarch@testing.com",
                Phone = "(202)867-5309"

            });
            context.Members.AddOrUpdate(new Models.Members
            {
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
        }
    }
}
