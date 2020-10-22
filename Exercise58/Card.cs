using Exercise58.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise58
{
    class Card
    {
        Suit suite { get; set; }
        string value { get; set; }
        public bool Suit { get; internal set; }

        public Card(Suit s, string v)
        {
            suite = s;
            value = v;
        }
    }
}
