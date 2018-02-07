using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanParty.Models
{
    public class Games
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Type { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public bool COOP { get; set; }
        public bool HostedPrivateServer { get; set; }
        public int EstimatedPlayTime { get; set; }
        public bool CrossPlatform { get; set; }

    }
}