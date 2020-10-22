using Exercise58.Enums;
using System;
using System.Collections.Generic;

namespace Exercise58
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Deck myDeck = new Deck();

                List<Card> shuffleDeck = new List<Card>();
                Random r = new Random();
                int p = 0;
                while (myDeck.Cards.Count > 0)
                {
                    p = r.Next(0, myDeck.Cards.Count);
                    shuffleDeck.Add(myDeck.Cards[p]);
                    myDeck.Cards.Remove(myDeck.Cards[p]);
                }
                myDeck.Cards = shuffleDeck;
                //Console.WriteLine(shuffleDeck[0].Suit);
            }
        }
    }
 }
