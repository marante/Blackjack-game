namespace Core.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public bool IsFinished { get; set; }
        public bool IsThick { get; set; }
        public Hand Hand { get; set; }

        public Player()
            : this("Noname")
        {

        }
        public Player(string name)
        {
            Name = name;
        }

    }
}
