using System;

namespace CardDeckCollections.Classes
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string Type { get; set; }

        public Card(Suit suit, string type)
        {
            Suit = suit;
            Type = type;
        }
    }

}

