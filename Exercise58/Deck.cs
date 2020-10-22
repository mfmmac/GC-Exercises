using Exercise58.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise58
{
    class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int y = 2; y < 11; y++)
                {
                    Cards.Add(new Card(suit, y.ToString()));
                }
                Cards.Add(new Card(suit, "A"));
                Cards.Add(new Card(suit, "J"));
                Cards.Add(new Card(suit, "Q"));
                Cards.Add(new Card(suit, "K"));
            }
        }
    }
}
