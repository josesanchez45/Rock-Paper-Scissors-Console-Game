using System.Runtime.CompilerServices;
using static System.Random;

Random random = new Random();
bool playAgain = true;
String player;
String computer;
String answer;

while (playAgain)
{
    answer = "";
    player = "";
    computer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER, SCISSORS:");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    switch (random.Next(1, 4))
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
    Console.WriteLine($"Player: {player}");
    Console.WriteLine($"Computer: {computer}");

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("Draw");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You Lose!");
            }
            else
                Console.WriteLine("You Win!");
            break;
        case "PAPER":
            if (computer == "PAPER")
            {
                Console.WriteLine("Draw");
            }
            else if (computer == "SCISSORS")
            {
                Console.WriteLine("You Lose!");
            }
            else
                Console.WriteLine("You Win!");
            break;
        case "SCISSORS":
            if (computer == "SCISSORS")
            {
                Console.WriteLine("Draw");
            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("You Lose!");
            }
            else
                Console.WriteLine("You Win!");
            break;

            Console.WriteLine("Would you like to play again? Y/N");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if(answer == "Y")
            {
                playAgain = true;
            }
            if(answer == "N")
            {
                playAgain = false;  
            }

    }
    
}
Console.WriteLine("Thanks for playing with us!");


