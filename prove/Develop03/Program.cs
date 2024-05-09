

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference();
        reference.LoadReference();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();
        Word word = new Word();

        int userChoice = 0;

        while (userChoice != 3)
        {
            userChoice = UserChoice();

            switch (userChoice)
            {
                case 1:
                    reference.ReferenceDisplay();
                    break;
                    
                case 2:
                    string script = scripture.RandomScripture();
                    string ref1 = reference.GetReference(scripture);
                    word.GetRenderedText(scripture);
                    word.GetRenderedRef(scripture);

                    while (word._hidden.Count < word._result.Length)
                    {
                        word.Show(ref1);
                        word.GetReadKey();
                    }
                    word.Show(ref1);
                    break;
                    
                case 3:
                    Console.WriteLine("\nBYE\n");
                    break;
                    
                default:
                    Console.WriteLine($"\nInvalid.");
                    break;
            }
        }
    }

    static int UserChoice()
    {
        Reference reference = new Reference();

        string choices = $@"
Please select one of the following choices:
1. Display all available scripture references
2. Randomly select scripture to work on
3. Quit

What would you like to do?  ";

        Console.Write(choices);

        string userInput = Console.ReadLine().ToLower();
        int userChoice = 0;
        
        try
        {
            if (userInput == "3" || userInput == "l")
            {
                userInput = "3";
            }
            userChoice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpected error:  {exception.Message}");
        }
        return userChoice;
    }
}