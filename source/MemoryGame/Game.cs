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
        private int currentIndex = 0;
        private bool nextPlayerFlag = true;
  
        public Player CurrentPlayer { get; set; }
        public int Score { get; set; }
        public Game(Settings settings)
        {
            this.Players = new Player[settings.Players];
            for (int i = 0; i < settings.Players; i++)
                Players[i] = new Player("Player" + i.ToString());
            CurrentPlayer = Players[0];
            Score = 0;
        }

        public void NextPlayer()
        {
            if (!nextPlayerFlag)
                return;
            currentIndex = (currentIndex + 1)% Players.Length;
            CurrentPlayer = Players[currentIndex];
        }

        public void FlagNextPlayer()
        {
            nextPlayerFlag = !nextPlayerFlag;     
        }

        public void Winner()
        {
            int score = 0;
            string name = "";

            foreach (Player player in Players)
            {
                if (player.Score > score)
                {
                    score = player.Score;
                    name = player.Name; 
                }
            }
            System.Windows.Forms.MessageBox.Show(name + " har vunnit med " + score.ToString() + " poäng!");

        }
    }
}
