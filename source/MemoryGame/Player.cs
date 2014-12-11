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
        private MemoryCardControl FirstCard { get; set; }
        public List<MemoryCardControl> mcList;
        public string level = "Lätt";
        private Random rnd;
        public AIPlayer(string name, string level) : base(name)
        {
            this.level = level;
            this.rnd = new Random();

        }
        public void OpenNewCard(List<MemoryCardControl> closedCardsList)
        {
           if (closedCardsList.Count == 0)
                return;
           Thread.Sleep(10);

            //öppna första kortet
           var card = GetCard(closedCardsList, true);
       
            card.Open(true);
            Thread.Sleep(10);

            //Öppnar andra kortet
            var card2 =  GetCard(closedCardsList, false);

            card2.Open(true);
            Thread.Sleep(10);
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

        private MemoryCardControl GetCard(List<MemoryCardControl> closedCardsList, bool first)
        {
            
            if (level == "Medel" || level == "Svår")
                return SmartGetCard(closedCardsList, first);
            else
                return GetRandomCard(closedCardsList);
        }


        private MemoryCardControl  SmartGetCard(List<MemoryCardControl> closedCardsList, bool first)
        {
            MemoryCardControl card;

            if (!first)
                card = FindMatch(FirstCard, closedCardsList);
            else if (!HasPair()){
                card = GetRandomCard(closedCardsList);
               this.FirstCard = card;
            }
            else 
            {
                card = GetFirstPair();
               this.FirstCard = card;
            }

            return card;
             

        }

        private MemoryCardControl FindMatch(MemoryCardControl FirstCard, List<MemoryCardControl> closedCardsList)
        {
            foreach (MemoryCardControl mc in mcList)
            {
                if (mc.Data == FirstCard.Data && mc != FirstCard)
                {
                    mcList.Remove(mc);
                    mcList.Remove(FirstCard);
                    return mc;
                }
            }
            return GetRandomCard(closedCardsList);
        }

        private MemoryCardControl GetRandomCard(List<MemoryCardControl> closedCardsList)
        {
           return closedCardsList[rnd.Next(closedCardsList.Count)];

        }

        private bool HasPair()
        {
            foreach (MemoryCardControl mc1 in this.mcList)
            {
                foreach (MemoryCardControl mc2 in this.mcList)
                {
                    if (mc1.Data == mc2.Data && mc1 != mc2)
                        return true;
                }
            }
            return false;
        }

        private MemoryCardControl GetFirstPair()
        {
            foreach (MemoryCardControl mc1 in this.mcList)
            {
                foreach(MemoryCardControl mc2 in this.mcList)
                {
                    if (mc1.Data == mc2.Data && mc1 != mc2)
                    {
                        this.mcList.Remove(mc1); 
                        return mc1;
                    }
                }
            }
            throw new ArgumentException(); 
        }

        private int EasyGetCard(List<MemoryCardControl> closedCardsList)
        {
            return rnd.Next(closedCardsList.Count);
        }

        
    }
}
