using System;

public class Score
{
    private Random random; // Declare the random variable

    public Score()
    {
        random = new Random(); // Initialize the random variable in the constructor
    }

    public int StartScore()
    {
        int randomNumber = random.Next(1, 14);
        int playerScore = randomNumber;
        return playerScore;
    }

    public int IncreasePlayerScore(int playerScore)
    {
        int randomValue = random.Next(1, 14);
        playerScore += randomValue;
        return playerScore;
    }
}