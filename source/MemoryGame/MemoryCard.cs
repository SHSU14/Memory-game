using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class MemoryCard
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string BackSide { get; set; }
        public int Counter { get; set; }

        //skapar nytt memoryCard med default-inställningar
        public MemoryCard()
        { 
            this.Symbol = "star1";
            this.BackSide = "CardBack";
        }

        public MemoryCard(string backSide, string symbol)
        {
            this.Symbol = symbol;
            this.BackSide = backSide;
        }

    }
}
