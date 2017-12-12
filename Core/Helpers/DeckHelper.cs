using Caliburn.Micro;
using Core.Models;
using System;
using System.Linq;

namespace Core.Helpers
{
    public class DeckHelper
    {
        /// <summary>
        /// Initializes a deck with 52 cards, 13 of each suite.
        /// </summary>
        public static BindableCollection<Card> InitializeDeck()
        {
            var deck = new[]
                {
                    CardSuite.Clubs,
                    CardSuite.Diamond,
                    CardSuite.Hearts,
                    CardSuite.Spades,
                }.SelectMany(
                    suit => Enumerable.Range(1, 13),
                    (suit, val) => new Card(suit, val))
                .ToList();

            return new BindableCollection<Card>(deck);
        }

        public static BindableCollection<Card> InitializeHand(Deck deck)
        {
            throw new NotImplementedException();
        }
    }
}
