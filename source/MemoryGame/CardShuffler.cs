using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
   public class CardShuffler
    {
        private List<MemoryCard> cardList;
        private Settings settings;

        public CardShuffler(Settings settings) 
        {
            this.settings = new Settings();
            GenerateCards();
        }

        private void GenerateCards()
        {
            int noCards = settings.CardNumber / 2;
            cardList = new List<MemoryCard>(noCards);
            for (int i = 0; i < noCards; i++)
            {
                var backSide = settings.Themes + "BackSide";
                var symbol = settings.Themes + i.ToString();
                cardList.Add(new MemoryCard(backSide, symbol));
            }
        }

        public void Shuffle(List<MemoryCardControl> controlList)
        {
            var rnd = new Random();
            for (int i = 0; i < controlList.Count; i++)
            {
                int index = rnd.Next(cardList.Count);
                MemoryCard card = cardList[index];
                controlList[i].Data = card;
                card.Counter -= 1;
                if (card.Counter == 0)
                    this.cardList.RemoveAt(index); 
            }
        }

    }
}
