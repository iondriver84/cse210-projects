using System;
using System.Collections.Generic;

public class Reference{

    private Scripture scripture;
    private List<Word> hiddenWords;

    public Reference(string reference, string text){
        scripture = new Scripture(reference, text);
        hiddenWords = new List<Word>();
    }
    public void DisplayScripture(){
        Console.Clear();
        Console.WriteLine(scripture.GetFormattedScripture());

        if (hiddenWords.Count == scripture.GetTotalWordCount())
        {
            Console.WriteLine("\nAll words have been hidden. Press enter to quit.");
            Console.ReadLine();
        }
        else{
            Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit"){
                return;
            }
            else{
                HideRandomWord();
                DisplayScripture();
            }
        }
    }    
        private void HideRandomWord(){
            List<Word> availableWords = scripture.GetVisibleWords();
            Random random = new Random();
            int index = random.Next(availableWords.Count);
            Word wordToHide = availableWords[index];

            wordToHide.Hide();
            hiddenWords.Add(wordToHide);
        }
    




}