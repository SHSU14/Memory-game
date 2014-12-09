using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MemoryGame
{
    public class Game
    {
        public List<Player> Playerlist {get; set;}
        public Settings settings;
        public Player[] Players { get; set; }
        public Player Winner { get; set; }
        private int currentIndex = 0;
        private bool ignore = false;
        public Color[] Colors = { Color.ForestGreen, Color.LimeGreen, Color.YellowGreen, Color.Orange, Color.Red, Color.DeepPink, Color.Violet, Color.Turquoise, Color.DeepSkyBlue, Color.Blue };
        public bool equalscore = false;

        public Player CurrentPlayer { get; set; }
        public int Score { get; set; }
        public Game(Settings settings)
        {
            
            this.Players = settings.Playerlist;
            this.settings = settings;

            CurrentPlayer = Players[0];
            Score = 0;
        Ended = false;

        }
       
        public void NextPlayer()
        {
            currentIndex = (currentIndex + 1)% Players.Length;
            CurrentPlayer = Players[currentIndex];
        }

        public bool Ignore()
        {
            ignore = !ignore;
            return ignore;
        }

        public void SetWinner()
        {
           
            int equals = 0;
            int score = 0;
            string name = "";
            Player winner = Players[0];

            foreach (Player player in Players)
            {
                if (player.Score >= score && player.Score > equals)
                {
                    if(player.Score == score)
                    {
                        equals = score; 
                    }
                    score = player.Score;
                    name = player.Name;
                    winner = player;
                }
            }
            if(equals < score) 
                this.Winner = winner;

            else
            {
                equalscore = true;
            }

            Ended = true;
        }

        public bool IsWon()
        {
            return this.Score == (this.settings.CardNumber / 2);
        }

        public bool Ended { get; set; }
    }
}
