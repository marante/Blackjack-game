namespace Core.Models
{
    /// <summary>
    /// Implementation of the dealer. Easily keeping track of current state of dealers hand.
    /// </summary>
    public class Dealer
    {
        public bool IsFinished { get; set; }
        public bool IsThick { get; set; }
        public Hand DealerHand { get; set; }

        public Dealer()
        {
        }
    }
}
