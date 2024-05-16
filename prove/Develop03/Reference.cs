<<<<<<< HEAD
using System;
 public class Reference
=======
public class Reference
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
{
    public List<Reference> _reference = new List<Reference>();
    private string _fileName = "scriptures.txt";
    private string _key;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
<<<<<<< HEAD
    public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
=======
    
    public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_fileName)
                                    .Where(arg => !string.IsNullOrWhiteSpace(arg))
                                    .ToList();
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Reference entry = new Reference();

            entry._key = entries[0];
            entry._book = entries[1];
            entry._chapter = int.Parse(entries[2]);
            entry._verseStart = int.Parse(entries[3]);
            entry._verseEnd = int.Parse(entries[4]);

            _reference.Add(entry);
        }
    }

    public void ReferenceDisplay()
    {
        foreach (Reference item in _reference)
        {
            if (item._verseEnd.Equals(0))
            {
                item.ReferenceOne();
            }
            else
            {
                item.ReferenceTwo();
            }
        }
    }
<<<<<<< HEAD
=======
    
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    public string GetReference(Scripture scripture)
    {
        var index = scripture._index;

        var refi = _reference[index];
        string ref1;
        if (refi._verseEnd.Equals(0))
        {
            return ref1 = ($"\n{refi._book} {refi._chapter}:{refi._verseStart}");
<<<<<<< HEAD
            
=======
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
        }
        else
        {
            return ref1 = $"\n{refi._book} {refi._chapter}:{refi._verseStart}-{refi._verseEnd}";
        }
    }

<<<<<<< HEAD

=======
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    public void ReferenceOne()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verseStart}");
    }
<<<<<<< HEAD
=======
    
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
    public void ReferenceTwo()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verseStart}-{_verseEnd}");
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 6e4ef94abef2a1d1c5719d672bff7c9d75a510d2
