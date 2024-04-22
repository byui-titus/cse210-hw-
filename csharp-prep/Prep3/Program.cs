using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, 
         Console.Write("What is the magic number? ");
         int magicNumber = int.Parse(Console.ReadLine());

         //UN COMMENT THE ENTRY FOR PART 3 BELOW AND COMENT PART 1 ABOVE FOR PART THREE
        
        // For Part 3, 
        //Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;

         while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
             guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 

        Console.WriteLine($"You made {guessCount} guesses.");

        Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();


    }
}