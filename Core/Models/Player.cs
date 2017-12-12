namespace Core.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }
        public bool IsFinished { get; set; }
        public bool IsThick { get; set; }
        public Hand PlayerHand { get; set; }

        public Player()
            : this("Noname", 100.0)
        {

        }
        public Player(string name)
            : this(name, 100.0)
        {
        }

        public Player(string name, double money)
        {
            Name = name;
            Money = money;
        }
    }
}
