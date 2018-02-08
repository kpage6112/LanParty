using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class Attendance
    {
        public int MemberID { get; set; }
        public int LanPartyID { get; set; }
        public DateTime ArrivalTime { get; set; }
        public bool HasPaid { get; set; }
        [ForeignKey ("MemberID")]
        public virtual Members Members { get; set; }
        [ForeignKey ("LanPartyID")]
        public virtual LanParty LanParty { get; set; }
    }
}