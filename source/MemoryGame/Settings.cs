using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Settings
    {
        public int Players { get; set; }
        public int AIPlayers { get; set; }
        public string AILevels { get; set; }
        public int CardNumber { get; set; }
        public string Themes { get; set; }
        public int PlayersTurnTimer { get; set; }
        public int ShowCardTimer { get; set; }

        public Settings()
        {
            Players = 12;
            AIPlayers = 0;
            this.CardNumber = 12;
            Themes = "frukt";
            PlayersTurnTimer = 4;
            ShowCardTimer = 2;
        }
    }
}
