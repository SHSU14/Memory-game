using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        private string level = "Lätt";
        private Random rnd;
        //private List<MemoryCardControl> closedCardsList;
        public AIPlayer(string name, string level) : base(name)
        {
            this.level = level;
            this.rnd = new Random();

        }
        public void OpenNewCard(List<MemoryCardControl> closedCardsList)
        {
           if (closedCardsList.Count == 0)
                return;
           Thread.Sleep(800);
           var index = GetIndex(closedCardsList, true);
            
            var card = closedCardsList[index];
            card.Open(true);
            Thread.Sleep(800);

            //Öppnar andra kortet
            index = GetIndex(closedCardsList, false);
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

        private int GetIndex(List<MemoryCardControl> closedCardsList, bool first)
        {
            
            if (level == "Medel")
                return MediumGetIndex(closedCardsList, first);
            else if (level == "Svår")
                return HardGetIndex(closedCardsList, first);
            else
                return EasyGetIndex(closedCardsList);
        }

        private int HardGetIndex(List<MemoryCardControl> closedCardsList, bool first)
        {
            throw new NotImplementedException();
        }

        private int MediumGetIndex(List<MemoryCardControl> closedCardsList, bool first)
        {
            if (!HasPair() && first)
                return rnd.Next(closedCardsList.Count);
            return 1;
        }

        private bool HasPair()
        {
            throw new NotImplementedException();
        }

        private int EasyGetIndex(List<MemoryCardControl> closedCardsList)
        {
            return rnd.Next(closedCardsList.Count);
        }
    }
}
