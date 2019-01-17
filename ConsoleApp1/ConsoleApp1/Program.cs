using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Here is a deck with 10 cards.");

            //Create 10 new cards in a new deck
            Deck<Card> myDeck = new Deck<Card>();

            Card c1 = new Card(Suit.Hearts, "Q");
            Card c2 = new Card(Suit.Hearts, "K");
            Card c3 = new Card(Suit.Spades, "J");
            Card c4 = new Card(Suit.Spades, "4");
            Card c5 = new Card(Suit.Clubs, "5");
            Card c6 = new Card(Suit.Clubs, "3");
            Card c7 = new Card(Suit.Hearts, "9");
            Card c8 = new Card(Suit.Diamonds, "A");
            Card c9 = new Card(Suit.Diamonds, "7");
            Card c10 = new Card(Suit.Spades, "8");

            Card[] cards = { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };
            for (int i = 0; i < 10; i++)
            {
                myDeck.Add(cards[i]);
            }
            PrintCards(myDeck);
        }
    }
}
