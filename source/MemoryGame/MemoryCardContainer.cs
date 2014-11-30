using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class MemoryCardContainer
    {
        private List<MemoryCard> mcList;

        public MemoryCardContainer(string theme, int noCards)
        {
            mcList = new List<MemoryCard>(noCards);
            for (int i = 0; i < noCards; i++)
            {
                var backSide = theme + "BackSide";
                var symbol = theme + i.ToString();
                mcList.Add(new MemoryCard (backSide, symbol));
            }
        }
    }
}
