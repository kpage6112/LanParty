using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class LanPartyContext : DbContext
    {

        public DbSet<Members> Members { get; set; }
        public DbSet<LanParty> LanParty { get; set; }
        public DbSet<Itinerary> Itinerary { get; set; }
        public DbSet<ItineraryItem> ItineraryItems {get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<GameOwned> GamesOwned {get;set;}
        public DbSet<Attendance> Attendance { get; set; }

    }
}