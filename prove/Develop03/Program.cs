

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        
=======
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
        Console.Clear();
        Reference reference = new Reference();
        reference.LoadReference();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();
        Word word = new Word();

<<<<<<< HEAD
        

        int userChoice = 0;
       

        while (userChoice != 3)
        {
            
=======
        int userChoice = 0;

        while (userChoice != 3)
        {
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
            userChoice = UserChoice();

            switch (userChoice)
            {
                case 1:
                    reference.ReferenceDisplay();
<<<<<<< HEAD

                    break;
=======
                    break;
                    
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
                case 2:
                    string script = scripture.RandomScripture();
                    string ref1 = reference.GetReference(scripture);
                    word.GetRenderedText(scripture);
                    word.GetRenderedRef(scripture);
<<<<<<< HEAD
                 
=======
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2

                    while (word._hidden.Count < word._result.Length)
                    {
                        word.Show(ref1);
                        word.GetReadKey();
                    }
                    word.Show(ref1);
                    break;
<<<<<<< HEAD
                case 3:
                    Console.WriteLine("\nBYE\n");
                    break;
                default:
                    Console.WriteLine($"\nINvalid.");
                    break;
            }
        }

=======
                    
                case 3:
                    Console.WriteLine("\nBYE\n");
                    break;
                    
                default:
                    Console.WriteLine($"\nInvalid.");
                    break;
            }
        }
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    }

    static int UserChoice()
    {
        Reference reference = new Reference();

        string choices = $@"
Please select one of the following choices:
<<<<<<< HEAD
1. Display all availble scriptures references
2. Randomly select scripture to work on
L. Quit
=======
1. Display all available scripture references
2. Randomly select scripture to work on
3. Quit
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2

What would you like to do?  ";

        Console.Write(choices);

<<<<<<< HEAD
        string userInput = Console.ReadLine();
        userInput.ToLower();
        int userChoice = 0;
        try
        {
            if (userInput == "L")
=======
        string userInput = Console.ReadLine().ToLower();
        int userChoice = 0;
        
        try
        {
            if (userInput == "3" || userInput == "l")
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
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
<<<<<<< HEAD
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
=======
            Console.WriteLine($"Unexpected error:  {exception.Message}");
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
        }
        return userChoice;
    }


}