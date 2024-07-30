





public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void SelectMove()
        {
            Console.WriteLine("Choose your move (rock, paper, scissors):");
            Move = Console.ReadLine().ToLower();
        }

      
    }

