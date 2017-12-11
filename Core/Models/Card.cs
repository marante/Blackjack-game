namespace Core.Models
{
    public class Card
    {
        private CardSuite _cardSuite;
        private int _cardValue;

        public CardSuite CardSuite { get; set; }
        public int CardValue { get; set; }

        public Card(CardSuite cardSuite, int cardValue)
        {
            _cardSuite = cardSuite;
            _cardValue = cardValue;
        }
    }
}