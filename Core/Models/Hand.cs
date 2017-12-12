using Caliburn.Micro;

namespace Core.Models
{
    public class Hand
    {
        private BindableCollection<Card> _cards;

        public int NumberOfCards { get; set; }
        public int Score { get; set; }

        public Hand(BindableCollection<Card> cards)
        {
            _cards = cards;
        }
    }
}