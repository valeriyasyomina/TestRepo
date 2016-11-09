using Cards.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>()
            {
                new Card() { DeparturePoint = "Мельбурн", DestinationPoint = "Кельн" },
                new Card() { DeparturePoint = "Москва", DestinationPoint = "Париж" },
                new Card() { DeparturePoint = "Кельн", DestinationPoint = "Москва" },

            };
            CardsSort sort = new CardsSort();
            cards = sort.Sort(cards);           
        }
    }
}
