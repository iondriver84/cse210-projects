using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        string[] verses = {
            "2 Nephi 2:25",
            "Alma 36:3",
            "1 Nephi 21:16",
            "Mosiah 23:18",
            "2 Nephi 32:3"
        };

        Random random = new Random();
        int verseIndex = random.Next(verses.Length);

        string randomVerse = verses[verseIndex];

        Reference reference = new Reference(randomVerse, Scripture.GetVerseText(randomVerse));

        reference.DisplayScripture();
    }
    
}