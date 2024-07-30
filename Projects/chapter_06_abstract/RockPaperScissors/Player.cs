   public abstract class Player
    {

        public string Name { get; set; }
        public string Move { get; set; }
        public int Score { get; set; }

        protected Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public abstract void SelectMove();

        public virtual void DisplayMove()
        {
            Console.WriteLine($"{Name} chose {Move}.");
        }

        public void AddPoint()
        {
            Score++;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Score: {Score}";
        }
}