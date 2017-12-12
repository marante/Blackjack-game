using Caliburn.Micro;

namespace Core.Models
{
    public class Deck
    {
        public BindableCollection<Card> Cards { get; set; }
        public int Count => Cards.Count;
    }
}
