using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class Attendance
    {
        [Key, Column (Order = 0)]
        public int MemberID { get; set; }
        [Key, Column(Order = 1)]
        public int LanPartyID { get; set; }
        public DateTime ArrivalTime { get; set; }
        public bool HasPaid { get; set; }
        
        [ForeignKey ("MemberID")]
        public virtual Members Members { get; set; }
        [ForeignKey ("LanPartyID")]
        public virtual LanParty LanParty { get; set; }
    }
}