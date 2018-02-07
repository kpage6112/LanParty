using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class Attendance
    {
        public string UserName { get; set; }
        public int LanPartyID { get; set; }
        public DateTime ArrivalTime { get; set; }
        public bool MyProperty { get; set; }
    }
}