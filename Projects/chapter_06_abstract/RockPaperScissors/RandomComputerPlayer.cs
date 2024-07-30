





public class RandomComputerPlayer : ComputerPlayer
    {
        private static readonly string[] Moves = { "rock", "paper", "scissors" };
        private static readonly Random Random = new Random();

        public RandomComputerPlayer(string name) : base(name) { }

        public override void SelectMove()
        {
            Move = Moves[Random.Next(Moves.Length)];
        }
    }

