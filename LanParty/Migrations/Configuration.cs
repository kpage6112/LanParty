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

        //    [Key]
        //public int ID { get; set; }
        //public DateTime Date { get; set; }
        //public DateTime StartTime { get; set; }
        //public DateTime EndTime { get; set; }
        //public string Location { get; set; }


        context.LanParty.AddOrUpdate(new LanParty.Models.LanParty{
            Date = new DateTime(2018, 02, 12),
            StartTime = new DateTime(2018, 02, 12, 10, 00, 00),
            EndTime = new DateTime(2018, 02, 13, 04, 00, 00),
            Location = "Somewhere"
        });
        }
    }
}
