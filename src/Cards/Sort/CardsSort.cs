using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Sort
{
    public class CardsSort : ISort
    {
        public List<Card> Sort(List<Card> cards)
        {
            if (cards == null)
                throw new ArgumentNullException();

            int i = 0;
            int j = 1;
            int nextCardIndex = j;           
            while (i < cards.Count - 1)
            {
                bool nextCardNotFound = true;                            
                while (j < cards.Count && nextCardNotFound)
                {
                    if (cards[i].DestinationPoint == cards[j].DeparturePoint)
                    {
                        var tmpCard = cards[i + 1];
                        cards[i + 1] = cards[j];
                        cards[j] = tmpCard;
                        nextCardNotFound = false;
                        nextCardIndex = j;
                    }
                    ++j;
                }
                if (nextCardNotFound && j != i + 1)
                {
                    --i;
                    j = nextCardIndex + 1;
                }
                else
                {
                    ++i;
                    j = i + 1;
                }
            }
            return cards;
        }
    }
}
