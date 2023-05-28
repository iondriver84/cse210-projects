using System;

using System.Collections.Generic;

public class Verse
{
    private List<Word> words;

    public Verse(string verseString)
    {
        words = new List<Word>();
        string[] wordStrings = verseString.Split(' ');

        foreach (string wordString in wordStrings)
        {
            Word word = new Word(wordString);
            words.Add(word);
        }
    }

    public string GetFormattedVerse()
    {
        string formattedVerse = "";

        foreach (Word word in words)
        {
            formattedVerse += word.GetFormattedWord() + " ";
        }
        return formattedVerse.Trim();
    }
    public List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        return visibleWords;
    }

    public int GetVisibleWordCount()
    {
        int visibleWordCount = 0;

        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                visibleWordCount++;
            }
        }
        return visibleWordCount;
    }
}