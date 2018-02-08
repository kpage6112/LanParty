using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class ItineraryItem
    {
        [Key]
        public int ID { get; set; }
        public int ItineraryID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Activity { get; set; }
        public int? GameID { get; set; }
        [ForeignKey ("ItineraryID")]
        public virtual Itinerary Itinerary { get; set; }
        [ForeignKey ("GameID")]
        public virtual Games Games { get; set; }
    }
}