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
        public Player[] Players { get; set; }
        public Player Winner { get; set; }
        private int currentIndex = 0;
        private bool ignore = false;
        public Color[] Colors = { Color.ForestGreen, Color.LimeGreen, Color.YellowGreen, Color.Orange, Color.Red, Color.DeepPink, Color.Violet, Color.Turquoise, Color.DeepSkyBlue, Color.Blue };
  
        public Player CurrentPlayer { get; set; }
        public int Score { get; set; }
        public Game(Settings settings)
        {
            this.Players = new Player[settings.Players];
            for (int i = 0; i < settings.Players; i++)
            {
                var player = new Player("Spelare " + (i + 1).ToString());
                player.Color = Colors[i];
                Players[i] = player;

            }
            CurrentPlayer = Players[0];
            Score = 0;
        }

        public void NextPlayer()
        {
            if (ignore)
                return;
            currentIndex = (currentIndex + 1)% Players.Length;
            CurrentPlayer = Players[currentIndex];
        }

        public void Ignore()
        {
            ignore = !ignore;     
        }

        public void SetWinner()
        {
            int score = 0;
            string name = "";
            Player winner = Players[0];

            foreach (Player player in Players)
            {
                if (player.Score > score)
                {
                    score = player.Score;
                    name = player.Name;
                    winner = player;
                }
            }
            this.Winner = winner;
        }
    }
}
