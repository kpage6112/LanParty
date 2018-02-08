﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class Itinerary
    {

        public int ID { get; set; }
        public int LanPartyID { get; set; }
        [ForeignKey ("LanPartyID")]
        public virtual LanParty LanParty { get; set; }
    }
}