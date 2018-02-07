using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class Itinerary
    {
        public int ID { get; set; }
        public int LanPartyID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Activity { get; set; }
        public int GameID { get; set; }
    }
}