using System;

namespace CardDeck.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[10];
        public int count = 0;


        // Enumerator to allow foreach for cards
        // returns each item from the deck
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        // Required to allow enumeration 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Adds a new card to the deck. If the deck is too small, resizes
        // the deck to twice the previous length, then adds card

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        //removes card
        public void Remove(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (card.Equals(cards[i]))
                {
                    for (int j = i; j < count - i - 1; j++)
                    {
                        cards[j] = cards[j + 1];
                    }
                    count--;
                }
            }

            




        }
    }
}