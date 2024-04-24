using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        
        while (playAgain)
        {
            int magicNumber = GenerateRandomNumber(1, 100);
            int guessCount = 0;

            Console.WriteLine("Welcome to Guess My Number game!");
            Console.WriteLine("I have picked a magic number between 1 and 100.");
            
            while (true)
            {
                Console.Write("What is your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }

            Console.WriteLine($"You made {guessCount} guesses.");
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput != "yes")
            {
                playAgain = false;
            }

            Console.WriteLine();
        }
    }

    static int GenerateRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);


    }
}