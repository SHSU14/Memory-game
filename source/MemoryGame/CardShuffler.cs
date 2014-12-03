using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
   public class CardShuffler
    {
        private Settings settings;

        public CardShuffler(Settings settings) 
        {
            this.settings = settings;
        }

       //genererar en lista med MemoryCards baserat på settings
        private List<MemoryCard> GenerateCards(int noCards)
        {
            var cardList = new List<MemoryCard>(noCards);
            for (int i = 0; i < noCards; i++)
            {
                var backSide = settings.Themes + "BackSide";
                var symbol = settings.Themes + i.ToString();
                cardList.Add(new MemoryCard(backSide, symbol));
            }
            return cardList;
        }


       //Tar en lista med MemoryCardControls och kopplar dem till ett slumpvis MemoryCard 
       //så att det finns två MemoryCardControls som pekar på varje MemoryCard.
        public void Shuffle(List<MemoryCardControl> controlList)
        {
            var cardList = GenerateCards(controlList.Count / 2);
            var rnd = new Random();
            for (int i = 0; i < controlList.Count; i++)
            {
                int index = rnd.Next(cardList.Count);
                MemoryCard card = cardList[index];
                controlList[i].Data = card;
                card.Counter -= 1;
                if (card.Counter == 0)
                    cardList.RemoveAt(index); 
            }
        }

    }
}
