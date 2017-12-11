using System;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Hand
    {
        private ObservableCollection<Card> _cards;

        public int NumberOfCards { get; set; }
        public int Score { get; set; }


        public Hand()
        {

        }
        public Hand(ObservableCollection<Card> cards)
        {
            _cards = cards;
        }

        public void AddCardToHand()
        {
            throw new NotImplementedException();
        }
    }
}