using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class GameOwned
    {
        public int GameID { get; set; }
        public string MemberID { get; set; }
        [ForeignKey ("GameID")]
        public virtual Games Games { get; set; }
        [ForeignKey("MemberID")]
        public virtual Members Members { get; set; }
    }
}