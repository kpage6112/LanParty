using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class LanParty
    {
        public int LanPartyID { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
    }
}