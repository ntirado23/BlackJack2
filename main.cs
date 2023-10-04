using System;

public class Program
{
    public static void Main(string[] args)
    {
        Score score = new Score();
        int playerScore = score.StartScore();
        int computerScore = score.StartScore(); // Generate computer's score

        Console.WriteLine("Welcome to BlackJack! Press any key to begin");
        Console.ReadKey();

        Console.WriteLine("What is your name?");
        string playerName = Console.ReadLine();

        Console.WriteLine("Hello " + playerName + " Your starting score is: " + playerScore + " Would you like to increase or hold?");

        // Loop until player score is less than or equal to 21
        while (playerScore < 21)
        {
            Console.WriteLine("Do you want to increase or hold?");
            string userChoice = Console.ReadLine().ToLower(); 

            if (userChoice == "increase")
            {
                
                playerScore = score.IncreasePlayerScore(playerScore);
                Console.WriteLine("Your updated score is: " + playerScore);
            }
            else if (userChoice == "hold")
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'increase' or 'hold'.");
            }
        }

        
        if (playerScore > 21)
        {
            Console.WriteLine("Sorry, you lose! Your score is over 21.");
        }
        else if (playerScore == 21)
        {
            Console.WriteLine("Congratulations! You win with a score of 21!");
        }
        else
        {
          
            while (computerScore < 17)
            {
                computerScore = score.IncreasePlayerScore(computerScore);
            }

            Console.WriteLine("Computer's score: " + computerScore);

            // Determine the winner
            if (computerScore > 21)
            {
                Console.WriteLine("Computer busts! You win!");
            }
            else if (computerScore == playerScore)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("Sorry, you lose! Computer's score is higher.");
            }
            else
            {
                Console.WriteLine("Congratulations! You win! Your score is higher than the computer's.");
            }
        }
    }
}