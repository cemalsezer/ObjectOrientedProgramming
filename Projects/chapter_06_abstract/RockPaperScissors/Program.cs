namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();
            Player human = new HumanPlayer(playerName);
            Player computer = new RandomComputerPlayer("AI");

            List<string> moveHistory = new List<string>();

            bool continuePlaying = true;
            while (continuePlaying)
            {
                human.SelectMove();
                computer.SelectMove();
                human.DisplayMove();
                computer.DisplayMove();
                string result = DetermineWinner(human, computer);
                Console.WriteLine(result);

                moveHistory.Add($"{human.Name} chose {human.Move}, {computer.Name} chose {computer.Move} - {result}");

                Console.WriteLine("Do you want to play again? (yes/no)");
                continuePlaying = Console.ReadLine().ToLower() == "yes";
            }

            Console.WriteLine("Game Over!");
            Console.WriteLine(human);
            Console.WriteLine(computer);
            Console.WriteLine("Move History:");
            foreach (var move in moveHistory)
            {
                Console.WriteLine(move);
            }


            static string DetermineWinner(Player player1, Player player2)
            {
                if (player1.Move == player2.Move)
                {
                    return "It's a tie!";
                }

                if ((player1.Move == "rock" && player2.Move == "scissors") ||
                    (player1.Move == "scissors" && player2.Move == "paper") ||
                    (player1.Move == "paper" && player2.Move == "rock"))
                {
                    player1.AddPoint();
                    return $"{player1.Name} wins!";
                }
                else
                {
                    player2.AddPoint();
                    return $"{player2.Name} wins!";
                }
            }


        }
    }
}


