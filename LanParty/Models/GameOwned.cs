using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class GameOwned
    {
        [Key, Column (Order =0)]
        public int GameID { get; set; }
        [Key, Column(Order = 1)]
        public int MemberID { get; set; }
        
        [ForeignKey ("GameID")]
        public virtual Games Games { get; set; }
        [ForeignKey("MemberID")]
        public virtual Members Members { get; set; }
    }
}