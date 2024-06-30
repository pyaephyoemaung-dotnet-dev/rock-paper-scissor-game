string player, bot;
int ramdon;
bool playAgain = true;
while (playAgain)
{
    int scorePlayer = 0;
    int scoreBot = 0;
    while (scorePlayer < 3 && scoreBot < 3)
    {
        Console.Write("Choose Rock, Paper and Scissor.\n\n");
        player = Console.ReadLine();
        Random rnd = new Random();
        ramdon = rnd.Next(1,4);
        switch (ramdon)
        {
            case 1:
                bot = "Rock";
                Console.WriteLine("Bot choose Rock.");
                if (player == "Rock" || player == "ROCK")
                {
                    Console.WriteLine("Draw.\n");
                }
                else if (player == "Paper" || player == "PAPER")
                {
                    Console.WriteLine("Win.\n");
                    scorePlayer++;
                }
                else if (player == "Scissor" || player == "SCISSOR")
                {
                    Console.WriteLine("Lose.\n");
                    scoreBot++;
                }
                break;
            case 2:
                bot = "Paper";
                Console.WriteLine("Bot choose Paper.");
                if (player == "Rock" || player == "ROCK")
                {
                    Console.WriteLine("Lose.\n");
                    scoreBot++;
                }
                if (player == "Paper" || player == "PAPER")
                {
                    Console.WriteLine("Draw.\n");
                }
                if (player == "Scissor" || player == "SCISSOR")
                {
                    Console.WriteLine("Win.\n");
                    scorePlayer++;
                }
                break;
            case 3:
                bot = "Scissor";
                Console.WriteLine("Bot choose Scissor.");
                if (player == "Rock" || player == "ROCK")
                {
                    Console.WriteLine("Win.\n");
                    scorePlayer++;
                }
                if (player == "Paper" || player == "PAPER")
                {
                    Console.WriteLine("Lose.\n");
                    scoreBot++;
                }
                if (player == "Scissor" || player == "SCISSOR")
                {
                    Console.WriteLine("Draw.\n");
                }
                break;
            default:
                Console.WriteLine("You didn't chooice.");
                break;
        }
        Console.WriteLine("\nSCORE:\tPlayer:\t{0}\tBot:\t{1}", scorePlayer, scoreBot);
    }
    if (scoreBot == 3)
    {
        Console.WriteLine("Bot win this match.");
    }
    else if (scorePlayer == 3)
    {
        Console.WriteLine("Congratulations! you win this match.");
    }
    Console.WriteLine("Do you want to play again? (y/n)");
    string gameloop = Console.ReadLine();
    if (gameloop == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else if (gameloop == "n")
    {
        playAgain = false;
    }
}