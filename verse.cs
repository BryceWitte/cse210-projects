using System;

class Verse
{
    private List<Word> _words;

    public Verse(String verse) 
    {
        // Create the list for words only when the object is created
        _words = new List<Word>();

        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string[] words = verse.Split(delimiterChars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }

    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }

    public bool IsAllHidden()
    {
        // TODO ask all words if thay are all hidden
        return false;
    }
}