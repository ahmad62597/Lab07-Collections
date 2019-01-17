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
