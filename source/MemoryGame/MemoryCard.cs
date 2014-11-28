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
        public System.Drawing.Image Symbol { get; set;}
        public System.Drawing.Image BackSide { get; set; }
        public int Timer { get; set; }

        //skapar nytt memoryCard med default inställningar
        public MemoryCard()
        {
            this.Symbol = global::MemoryGame.Properties.Resources.star1;
            this.BackSide = global::MemoryGame.Properties.Resources.CardBack;
        }


    }
}
