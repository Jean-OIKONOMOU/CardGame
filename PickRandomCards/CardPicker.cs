using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        public static List<string> PickSomeCards(int cards)
        {
            //string[] randomCards = new string[] { };
            var randomCards = new List<string>() { };
            for (int i = 0; i < cards; i++)
            {
                string card = NewUniqueCard(RandomValue() + " " + RandomSuit(), randomCards);
                randomCards.Add(card);
            }

            return randomCards;
        }

        static Random Random = new Random();

        static string RandomValue() {
            //int rand = Random.Next(1, 13);
            //string[] cardValues = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
            //                       "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            int rand = Random.Next(0, 3);
            string[] cardValues = {"Ace", "Two", "Three"};
            return cardValues[rand];
        }
        static string RandomSuit() {
            //int rand = Random.Next(1, 4);
            //string[] cardSuits = {"of Spades", "of Clubs", "of Hearts", "of Diamonds"};
            int rand = Random.Next(0, 2);
            string[] cardSuits = {"of Spades", "of Clubs"};
            return cardSuits[rand];
        }   

        static string NewUniqueCard(string card, List<string> cards)
        {
            if (cards.Contains(card)) {
                return NewUniqueCard(RandomValue() + " " + RandomSuit(), cards);
            } else {
                return card;
            }
        }
    }
}
