using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.IO;
using System.Linq;

>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
public class Word
{
    public string _words = "";
    public string _ref = "";
    public string[] _result;
    public List<int> _hidden;
<<<<<<< HEAD
    public Word()
    {
    }
    public Word(string text, string visible)
    {

    }
=======
    
    public Word()
    {
    }
    
    public Word(string text, string visible)
    {
    }
    
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    public void GetRenderedText(Scripture scripture)
    {
        var _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }
<<<<<<< HEAD
=======
    
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    public void GetRenderedRef(Scripture scripture)
    {
    }

    public void Show(string ref1)
    {
<<<<<<< HEAD
       _ref = ref1;
        Console.Clear();
        Console.Write("spacebar or enter to hide words");
        Console.Write(" Press Q to Quit");
        Console.WriteLine($"{_ref}");
=======
        _ref = ref1;
        Console.Clear();
        Console.WriteLine("spacebar or enter to hide words");
        Console.WriteLine("Press Q to Quit");
        Console.WriteLine($"{_ref}");
        
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new String('-', len);
<<<<<<< HEAD
=======
            
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
            if (_hidden.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
        }
    }

    public void GetReadKey()
    {
        var input = Console.ReadKey();
<<<<<<< HEAD
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWord();

=======
        
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWord();
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
    }
<<<<<<< HEAD
=======
    
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    public void GetNewHiddenWord()
    {
        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
<<<<<<< HEAD
=======
        
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
        if (_hidden.Contains(index1) || _hidden.Contains(index2))
        {
            GetNewHiddenWord();
        }
        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);
<<<<<<< HEAD

        }
    }


=======
        }
    }
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
}