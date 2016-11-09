using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Cards;
using Cards.Sort;

namespace SortCardsTest
{
    [TestClass]
    public class TestSortCards
    {
        [TestMethod]
        public void Test1()
        {
            // arrange
            List<Card> cards = new List<Card>()
            {
                new Card() { DeparturePoint = "Мельбурн", DestinationPoint = "Кельн" },
                new Card() { DeparturePoint = "Москва", DestinationPoint = "Париж" },
                new Card() { DeparturePoint = "Кельн", DestinationPoint = "Москва" },

            };
            List<Card> sortedCards = new List<Card>()
            {
                new Card() { DeparturePoint = "Мельбурн", DestinationPoint = "Кельн" },
                new Card() { DeparturePoint = "Кельн", DestinationPoint = "Москва" },
                new Card() { DeparturePoint = "Москва", DestinationPoint = "Париж" },
            };
            // act
            CardsSort sort = new CardsSort();
            cards = sort.Sort(cards);

            // assert        
            CollectionAssert.AreNotEqual(cards, sortedCards);
        }

        [TestMethod]
        public void Test2()
        {
            // arrange
            List<Card> cards = new List<Card>()
            {
                new Card() { DeparturePoint = "Moscow", DestinationPoint = "Berlin" },
                new Card() { DeparturePoint = "St. Petersburg", DestinationPoint = "Berlin" },
                new Card() { DeparturePoint = "Bern", DestinationPoint = "St. Petersburg" },
                new Card() { DeparturePoint = "Berlin", DestinationPoint = "Melburn" },
                new Card() { DeparturePoint = "Berlin", DestinationPoint = "New York" },
                new Card() { DeparturePoint = "New York", DestinationPoint = "Bern" },

            };
            List<Card> sortedCards = new List<Card>()
            {
                new Card() { DeparturePoint = "Moscow", DestinationPoint = "Berlin" },
                new Card() { DeparturePoint = "Berlin", DestinationPoint = "New York" },
                new Card() { DeparturePoint = "New York", DestinationPoint = "Bern" },
                new Card() { DeparturePoint = "Bern", DestinationPoint = "St. Petersburg" },
                new Card() { DeparturePoint = "St. Petersburg", DestinationPoint = "Berlin" },                
                new Card() { DeparturePoint = "Berlin", DestinationPoint = "Melburn" },            
            };
            // act
            CardsSort sort = new CardsSort();
            cards = sort.Sort(cards);

            // assert        
            CollectionAssert.AreNotEqual(cards, sortedCards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test3()
        {
            // arrange
            List<Card> cards = null;

            // act
            CardsSort sort = new CardsSort();
            cards = sort.Sort(cards);
        }

    }
}
