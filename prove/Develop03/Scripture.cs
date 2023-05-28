using System;
using System.Collections.Generic;

public class Scripture{
    private string reference;
    private string text;
    private List<Verse> verses;

    public Scripture(string reference, string text){
        this.reference = reference;
        this.text = text;
        verses = ParseVerses(text);
    }

    public string GetFormattedScripture()
    {
        string formattedScripture = reference + "\n\n";
        foreach (Verse verse in verses)
        {
            formattedScripture += verse.GetFormattedVerse() + " ";
        }
        return formattedScripture.Trim();
    }
    public List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Verse verse in verses)
        {
            visibleWords.AddRange(verse.GetVisibleWords());
        }
        return visibleWords;
    }

    public int GetTotalWordCount()
    {
        int totalWordCount = 0;

        foreach (Verse verse in verses)
        {
            totalWordCount += verse.GetVisibleWordCount();
        }
        return totalWordCount;
    }
    
    private List<Verse> ParseVerses(string text)
    {
        List<Verse> parsedVerses = new List<Verse>();

        string[] verseStrings = text.Split(new[] { ' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string verseString in verseStrings)
        {
            Verse verse = new Verse(verseString);
            parsedVerses.Add(verse);
        }
        return parsedVerses;
    }
    public static string GetVerseText(string verseReference)
    {
        switch (verseReference)
        {
            case "2 Nephi 2:25":
                return "Adam fell that men might be; and men are, that they might have joy.";
            case "Alma 36:3":
                return "Whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.";
            case "1 Nephi 21:16":
                return "Behold, I have graven thee upon the palms of my hands.";
            case "Mosiah 23:18":
                return "Therefore they did watch over their people, and did nourish them with things pertaining to righteousness.";
            case "2 Nephi 32:3":
                return "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.";
            default:
                return string.Empty;
        }
    }
}