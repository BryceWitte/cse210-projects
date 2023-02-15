using System;

class Scripture
{
    // Create the list of verses before the constructor is called.
    private List<Verse> _verses = new List<Verse>();

    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }

    public bool HideWords(int count)
    {   
        // TODO finish the method
        return false;
    }

    public bool IsAllHidden()
    {
        // TODO ask all verses if thay are hidden
        return false;
    }
}