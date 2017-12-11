using System;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Deck
    {
        private ObservableCollection<Card> _cards;

        public ObservableCollection<Card> Cards { get; set; }
        public int Count => Cards.Count;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck()
        {

        }

        public void DrawNextCard()
        {
            throw new NotImplementedException();
        }

        private void FillDeckWithCards()
        {
            throw new NotImplementedException();
        }

        private void InitializeDeck()
        {
            throw new NotImplementedException();
        }

        public void ShuffleDeck()
        {
            throw new NotImplementedException();
        }
    }
}
