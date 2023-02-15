using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
            { 
                "And it came to pass",
                "the house is blue",
                "the end"
            };


        Scripture scrip = new Scripture(verses);
        scrip.Display();
        scrip.HideWords(3);
        scrip.IsAllHidden();
    }
}

