// See https://aka.ms/new-console-template for more information

Random random = new Random();
bool playAgain = true;

string player;
string computer;
string answer;

while (playAgain)
{
    player = "";
    computer = "";
    answer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER, OR SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    switch (random.Next(1,4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine($"Player :{player}");
    Console.WriteLine($"Computer :{computer}");

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("Tie");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("Lose");
            } else
            {
                Console.WriteLine("Win");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine("Win");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("Tie");
            } else
            {
                Console.WriteLine("Lose");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("Lose");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("Win");
            } else
            {
                Console.WriteLine("Tie");
            }
            break;
    }

    Console.WriteLine("Would you like to play again(Y/N)");
    answer = Console.ReadLine();
    answer = answer.ToUpper();
    if (answer == "Y")
    {
        playAgain = true;
    }
    else 
    {
        playAgain = false;
    }
    
}

Console.WriteLine("Thanks for playing!");

