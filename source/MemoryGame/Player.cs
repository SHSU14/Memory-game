using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryGame
{
   public class Player
    {
    
       public Player(string name)
       {
           this.Name = name;
           Score = 0;
       }
       public string Name { get; set; }
       public int Score { get; set; }

       protected int waitTime;

       public System.Drawing.Color Color { get; set; }

      
    }

    public class AIPlayer: Player
    {
        private List<MemoryCardControl> mcList;
        public AIPlayer(string name, int waitTimer) : base(name)
        {
           
        }
        public void OpenNewCard(List<MemoryCardControl> closedCardsList)
        {
           if (closedCardsList.Count == 0)
                return;
            Thread.Sleep(800);
            Random rnd = new Random();
            var index = rnd.Next(closedCardsList.Count);
            
            var card = closedCardsList[index];
            card.Open(true);
            Thread.Sleep(800);

            //Öppnar andra kortet
            index = rnd.Next(closedCardsList.Count);
            var card2 = closedCardsList[index];
            card2.Open(true);
            Thread.Sleep(800);
            if (card.IsMatched())
            {
                OpenNewCard(closedCardsList); 

            }
            else
            {
                card.Close();
                card2.Close();
               
            }

        }
    }
}
