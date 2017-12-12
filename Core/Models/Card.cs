namespace Core.Models
{
    public class Card
    {

        public CardSuite CardSuite { get; set; }
        public int CardValue { get; set; }

        public Card(CardSuite cardSuite, int cardValue)
        {
            CardSuite = cardSuite;
            CardValue = cardValue;
        }
    }
}