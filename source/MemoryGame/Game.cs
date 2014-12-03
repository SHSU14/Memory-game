using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Game
    {
        public Player[] Players { get; set; }
        public Player Winner { get; set; }
        private int currentIndex = 0;
        private bool ignore = false;
  
        public Player CurrentPlayer { get; set; }
        public int Score { get; set; }
        public Game(Settings settings)
        {
            this.Players = new Player[settings.Players];
            for (int i = 0; i < settings.Players; i++)
                Players[i] = new Player("Spelare " + (i+1).ToString());
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
